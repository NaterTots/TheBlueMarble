﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeoCoding;
using BlueMarble.Data;
using System.Data.Entity;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BlueMarble.TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<MarbleDataBase>(new DropCreateDatabaseAlways<MarbleDataBase>());
            // Testing geocoding utilities
            //Address address = GeocodingUtils.MicrosoftGeocodeAddress("28500 Clemens Road Westlake, OH 44145");
            //Console.WriteLine("Found latitude and longtiude for {0}", address.FormattedAddress);
            //Console.WriteLine("Latitude, Longitude:  {0}, {1}", address.Coordinates.Latitude, address.Coordinates.Longitude);

            /*MarbleDataBase db = new MarbleDataBase();
            db.Dataset.Add(new Dataset() { Description = "aljdsfjlaksdf" });
            db.SaveChanges();*/

            /*Dataset set = db.Dataset.Find(1);
            if (set != null)
            {
                Console.Write("Description is: " + set.Description);
            }*/

            FileStream stream = new FileStream("new.gif", FileMode.Create);
            //IEnumerable<BlueMarble.Data.ImageData> listOfImages = IEnumerable. BlueMarble.Data.ImageData[]();
            //GifCreator.GifMaker bleh = new GifCreator.GifMaker();

            //GifBitmapEncoder newGif = bleh.Create(listOfImages, 10);
  
            
        }
    }
}
