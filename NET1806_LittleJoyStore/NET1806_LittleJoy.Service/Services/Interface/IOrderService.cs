﻿using Microsoft.AspNetCore.Http;
using NET1806_LittleJoy.API.ViewModels.RequestModels;
using NET1806_LittleJoy.Repository.Commons;
using NET1806_LittleJoy.Repository.Entities;
using NET1806_LittleJoy.Service.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET1806_LittleJoy.Service.Services.Interface
{
    public interface IOrderService
    {
        public Task<OrderResponseModel> CreateOrder(OrderRequestModel model, HttpContext context);

        public Task<Pagination<OrderWithDetailsModel>> GetOrderByUserId(PaginationParameter parameter, int userId);

        public Task<bool> UpdateOrderDelivery(OrderUpdateRequestModel model);

        public Task<bool> UpdateOrderStatus(OrderUpdateRequestModel model);

        public Task<OrderWithDetailsModel> GetOrderByOrderCode(int orderCode);

        public Task<Pagination<OrderWithDetailsModel>> OrderFilterAsync(PaginationParameter parameter, OrderFilterModel filterModel);

        public Task<bool> CheckCancelOrder(int OrderCode);

        public Task<int> GetRevenueToday();

        public Task<int> CountOrder(bool status);

        public Task<List<RevenueOverviewModel>> GetRevenueOverview();

        public Task<List<ProductHighSalesModel>> GetProductHighSales();
    }
}
