using Booking.DataAccess.Repositories;
using BookingWeb.Models;
using BookingWeb.Services;
using System;
using System.Linq;
using System.Web.Mvc;

namespace BookingWeb.Controllers
{
    public class TrainController : Controller
    {
        private readonly ITrainRepository _trainRepository;
        private readonly ITrainService _trainService;

        public TrainController(ITrainRepository trainRepository, ITrainService trainService)
        {
            _trainRepository = trainRepository;
            _trainService = trainService;
        }

        public ActionResult Index()
        {
            var trainListModel = new TrainsModel
            {
                CurrentTrains = _trainRepository.GetTrains()
            };
            return View(trainListModel);
        }

        public ActionResult Search(string startArrivalTime, string endArrivalTime)
        {
            if (!(string.IsNullOrEmpty(startArrivalTime) && string.IsNullOrEmpty(endArrivalTime)))
            {
                var start = new TimeSpan();
                var end = new TimeSpan();
                start = TimeSpan.Parse(startArrivalTime);
                end = TimeSpan.Parse(endArrivalTime);

                var currentTrains = _trainRepository.GetTrains().Where(t => (start <= t.Stations[0].Arrival && t.Stations[0].Arrival <= end)).ToList();
                var trainListModel = new TrainsModel
                {
                    CurrentTrains = currentTrains,
                    StartTime = startArrivalTime,
                    EndTime = endArrivalTime
                };
                return View("Index", trainListModel);
            }
            return RedirectToAction("Index");
        }

        public ActionResult ShowTrainDetails(int number, string startArrivalTime, string endArrivalTime)
        {
            TrainDetailModel trainDetailModel = new TrainDetailModel
            {
                CurrentTrain = _trainRepository.GetTrain(number),
                StartTime = startArrivalTime,
                EndTime = endArrivalTime
            };
            

            return View("TrainDetail", trainDetailModel);
        }

        [HttpPost]
        public ActionResult DeleteTrain(TrainItem trainItem)
        {
            var trains = _trainRepository.GetTrains().Skip(1).ToList();

            return Json(trains);
        }
    }
}