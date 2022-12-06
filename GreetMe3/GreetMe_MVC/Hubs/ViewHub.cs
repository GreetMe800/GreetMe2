using Microsoft.AspNetCore.SignalR;
using GreetMe_MVC.Models;
using NuGet.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GreetMe_MVC;
using System.Web.Http.ModelBinding;
using System.Security.Cryptography.X509Certificates;

namespace SignalRChat.Hubs
{
    public class ViewHub : Hub
    {
        public ViewHub()
        {

        }

        public async Task SendViews()
        {
            IEnumerable<ViewViewModel> viewList = null;

            //Establish Connection
            var client = ApiHelper.InitializeClient("http://localhost:5184/api/");

            //HTTP GETALL
            var responseTask = await client.GetAsync("view");
            if (responseTask.IsSuccessStatusCode)
            {
                var viewViewModelList = await responseTask.Content.ReadAsAsync<IList<ViewViewModel>>();
                viewList = viewViewModelList;
            }
            else // If Error
            {
                viewList = Enumerable.Empty<ViewViewModel>();
            }

            await Clients.All.SendAsync("ReceivedViews", viewList);
        }
    }
}