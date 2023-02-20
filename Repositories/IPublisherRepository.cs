﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public interface IPublisherRepository
	{
		List<Publisher> GetPublishers();
		Publisher GetPublisherById(int id);
		void SavePublisher(Publisher publisher);
		void UpdatePublisher(Publisher publisher);
		void DeletePublisher(Publisher publisher);
	}
}
