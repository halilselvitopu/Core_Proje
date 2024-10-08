﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void AddT(SocialMedia t)
        {
            _socialMediaDal.Insert(t);
        }

        public void DeleteT(SocialMedia t)
        {
            _socialMediaDal.Delete(t);
        }

        public SocialMedia GetByIdT(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public List<SocialMedia> GetListT()
        {
            return _socialMediaDal.GetList();
        }

        public void UpdateT(SocialMedia t)
        {
            _socialMediaDal.Update(t);
        }
    }
}
