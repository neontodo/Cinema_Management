using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// Summary description for WebClient
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebClient : System.Web.Services.WebService
    {

        [WebMethod]
        public List<string> GetAllCinemas()
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public int GetCinemaByLocation(string cinemaLocation)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public List<string> GetAllMoviesDetailsByDay(int cinemaId, string weekDay)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public List<string> GetAllMoviesDetailsByName(int cinemaId, string name)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public bool CreateReservation(List<string> details)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public List<string> GetAllReservationsByClient(int clientId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteReservation(int reservationId)
        {
            throw new NotImplementedException();
        }
    }
}
