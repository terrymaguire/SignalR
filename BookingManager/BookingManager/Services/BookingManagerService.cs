//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Threading;
//using Microsoft.AspNet.SignalR;
//using Microsoft.AspNet.SignalR.Hubs;
//using BookingManager.Models;

//namespace BookingManager.Services
//{
//    public class BookingManagerService
//    {
//        // Singleton instance
//        private readonly static Lazy<BookingManagerService> instance = new Lazy<BookingManagerService>(() => new BookingManagerService(GlobalHost.ConnectionManager.GetHubContext<BookingManagerHub>().Clients));

//        private BookingManagerService(IHubConnectionContext clients)
//        {
//            Clients = clients;
//        }

//        public static BookingManagerService Instance
//        {
//            get
//            {
//                return instance.Value;
//            }
//        }

//        private IHubConnectionContext Clients { get; set; }

//        public void BroadcastLatestBooking(Booking booking)
//        {
//            Clients.All.updateBooking(booking);
//        }
//    }
//}