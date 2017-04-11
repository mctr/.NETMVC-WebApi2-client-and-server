using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiServer.Models;

namespace WebApiServer.Controllers
{
    public class MeetingController : ApiController
    {
        private MeetingEntities db = new MeetingEntities();

        // GET: api/Meeting
        [HttpGet]
        public IEnumerable<Meetings> Get()
        {
            MeetingEntities db = new MeetingEntities();
            return db.Meetings.ToList(); //AsEnumerable<Meetings>();
        }


        // GET: api/Meeting/5
        [HttpGet]
        public Meetings Get(int id)
        {
            return db.Meetings.Where(a => a.id == id).FirstOrDefault<Meetings>();
        }



        // POST: api/Meeting
        [HttpPost]
        public void Post(Meetings meeting)
        {
            db.Meetings.Add(meeting);
            db.SaveChanges();
        }


        // PUT: api/Meeting/5
        [HttpPut]
        public void Put(int id, Meetings meeting)
        {
            Meetings old = db.Meetings.First(a => a.id == id);
            old.MeetingTopic = meeting.MeetingTopic;
            old.MeetingDate = meeting.MeetingDate;
            old.MeetingStartTime = meeting.MeetingStartTime;
            old.MeetingFinishTime = meeting.MeetingFinishTime;
            old.Participants = meeting.Participants;
            db.SaveChanges();
        }


        // DELETE: api/Meeting/5
        //Bu metodu kullanmayacagım ama yine hazır dursun istedim.
        public void Delete(int id)
        {
            Meetings delete = db.Meetings.First(a => a.id == id);
            db.Meetings.Remove(delete);
            db.SaveChanges();
        }

    }
}
