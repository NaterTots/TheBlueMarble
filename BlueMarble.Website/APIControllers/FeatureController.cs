﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BlueMarble.Data;

namespace BlueMarble.Website.APIControllers
{
    public class FeatureController : ApiController
    {
		MarbleDataBase _database;

		public FeatureController()
		{
			_database = new MarbleDataBase();
		}

		public MarbleDataBase Database
		{
			get { return _database; }
		}

		/// <summary>
		/// Returns all features
		/// </summary>
		/// <returns>IEnumerable list of Featuredesc</returns>
		public IEnumerable<Featuredesc> GetFeatures()
		{
			IEnumerable<Featuredesc> features = (from feature in Database.Featuredesc
												 select feature);

			return features;
		}
    }
}
