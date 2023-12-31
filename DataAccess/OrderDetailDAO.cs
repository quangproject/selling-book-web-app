﻿using BusinessObjects;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
	public class OrderDetailDAO
	{
		public static List<OrderDetail> FindOrderDetailById(int orderId)
		{
			var lstOrderDetail = new List<OrderDetail>();
			try
			{
				using (var context = new ApplicationDbContext())
				{
					lstOrderDetail = context.OrderDetails.Include(b => b.Book).Where(x => x.OrderId == orderId && x.Book.IsDeleted == false).ToList();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
			return lstOrderDetail;
		}

		public static void SaveOrderDetail(OrderDetail orderDetail)
		{
			try
			{
				using (var context = new ApplicationDbContext())
				{
					context.OrderDetails.Add(orderDetail);
					context.SaveChanges();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
	}
}
