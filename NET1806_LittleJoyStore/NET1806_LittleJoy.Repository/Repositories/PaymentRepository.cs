﻿using Microsoft.EntityFrameworkCore;
using NET1806_LittleJoy.Repository.Entities;
using NET1806_LittleJoy.Repository.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET1806_LittleJoy.Repository.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly LittleJoyContext _context;

        public PaymentRepository(LittleJoyContext context) 
        {
            _context = context;
        }

        public async Task<bool> CreateNewPayment(Payment payment)
        {
            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Payment?> GetPaymentByOrderCode(int orderCode)
        {
            var result =  await _context.Payments.Where(x=> x.Code == orderCode).FirstOrDefaultAsync();
            return result;
        }
    }
}
