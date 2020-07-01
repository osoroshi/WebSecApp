﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSecApp.Models;
using WebSecApp.ViewModels;

namespace WebSecApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
      //  private readonly ISecserviceRepository _ordersrepository;
        //    private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository /* ShoppingCart shoppingCart */)
        {
            _orderRepository = orderRepository;
          //  _shoppingCart = shoppingCart;
        }

        // GET: /<controller>/
        public IActionResult Checkout()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            //var items = _shoppingCart.GetShoppingCartItems();
            //_shoppingCart.ShoppingCartItems = items;

            //if (_shoppingCart.ShoppingCartItems.Count == 0)
            //{
            //    ModelState.AddModelError("", "Your cart is empty, add some pies first");
            //}

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
              //  _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "TDL thanks you for your order.";
            return View();
        }

        public ViewResult OrdersList()
        {

            SecServiceOrderViewModel secserviceordersviewmodel = new SecServiceOrderViewModel();
            secserviceordersviewmodel.Orders = _orderRepository.AllOrders;
            return View(secserviceordersviewmodel);

        }





    }
}