﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using CrowdSub.Models;
using System.Web.Mvc;

namespace CrowdSub.Repositories
{
    public class video_repository : i_video_repository
    {
        //Database connection.
        private crowddbEntities db = new crowddbEntities();

        public IQueryable<video> get_videos()
        {
            return db.videos;
        }


        public video add(video video)
        {
            db.videos.Add(video);
            db.SaveChanges();
            int id = db.videos.OrderByDescending(x => x.id).First().id;
            return db.videos.Where(x => x.id == id).FirstOrDefault();
        }

        public video edit(int id, video video)
        {
            
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            video video_to_delete = db.videos.Where(x => x.id == id).FirstOrDefault();
            if (video_to_delete != null) 
            {
                var video_del = (from v in db.videos
                                where v.id == id
                                select v).FirstOrDefault();

                db.videos.Remove(video_del);
                db.SaveChanges();

                return true;
            }
            
            return false;
        }
    }
}