﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BooksShopOnline.Models;
namespace BooksShopOnline.Logic
{
    public class ShoppingCartActions : IDisposable
    {
        public string ShoppingCartId { get; set; }
        private SportContext _db = new SportContext();
        public const string CartSessionKey = "Id";
        public void AddToCart(int id)
        {
            // Retrieve the product from the database.
            ShoppingCartId = GetCartId();
            var cartItem = _db.ShoppingCartItems.SingleOrDefault(
            c => c.CartId == ShoppingCartId
            && c.BookId == id);
            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists.
                cartItem = new CartItem
                {
                    ItemId = Guid.NewGuid().ToString(),
                    SportId = id,
                    CartId = ShoppingCartId,
                    Sport = _db.Sports.SingleOrDefault(
                p => p.SportID == id),
                    Quantity = 1,
                    DateCreated = DateTime.Now
                };
                _db.ShoppingCartItems.Add(cartItem);
            }
            else
            {
                // If the item does exist in the cart,
                // then add one to the quantity.
                cartItem.Quantity++;
            }
            _db.SaveChanges();
        }
        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }
        public string GetCartId()
        {
            if (HttpContext.Current.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[CartSessionKey] =
                    HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return HttpContext.Current.Session[CartSessionKey].ToString();
        }
        public List<CartItem> GetCartItems()
        {
            ShoppingCartId = GetCartId();
            return _db.ShoppingCartItems.Where(
            c => c.CartId == ShoppingCartId).ToList();
        }
        public decimal GetTotal()
        {
            ShoppingCartId = GetCartId();
            // Tổng tiền mỗi cuốn sách (Item Total) = đơn giá (UnitPrice) nhân
            // số lượng (Quantity). Tổng của các tổng tiền chính là
            // số tiền mà người dùng phải trả (Order Total)
            decimal? total = decimal.Zero;
            total = (decimal?)(from cartItems in _db.ShoppingCartItems
                               where cartItems.CartId == ShoppingCartId
                               select (int?)cartItems.Quantity *
                               cartItems.Book.UnitPrice).Sum();
            return total ?? decimal.Zero;
        }
        public ShoppingCartActions GetCart(HttpContext context)
        {
            using (var cart = new ShoppingCartActions())
            {
                cart.ShoppingCartId = cart.GetCartId();
                return cart;
            }
        }
        public void UpdateShoppingCartDatabase(String cartId, ShoppingCartUpdates[]
        CartItemUpdates)
        {
            using (var db = new BooksShopOnline.Models.SportContext())
            {
                try
                {
                    int CartItemCount = CartItemUpdates.Count();
                    List<CartItem> myCart = GetCartItems();
                    foreach (var cartItem in myCart)
                    {
                        // Lặp qua các hàng trong giỏ hàng
                        for (int i = 0; i < CartItemCount; i++)
                        {
                            if (cartItem.Sport.SportID == CartItemUpdates[i].SportId)
                            {
                                if (CartItemUpdates[i].PurchaseQuantity < 1 ||
                                CartItemUpdates[i].RemoveItem == true)
                                {
                                    RemoveItem(cartId, cartItem.SportId);
                                }
                                else
                                {
                                    UpdateItem(cartId, cartItem.SportId,
                                    CartItemUpdates[i].PurchaseQuantity);
                                }
                            }
                        }
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Update Cart Database - " +
                    exp.Message.ToString(), exp);
                }
            }
        }
        public void RemoveItem(string removeCartID, int removeBookID)
        {
            using (var _db = new BooksShopOnline.Models.SportContext())
            {
                try
                {
                    var myItem = (from c in _db.ShoppingCartItems
                                  where c.CartId == removeCartID && c.Book.BookID ==
                                  removeBookID
                                  select c).FirstOrDefault();
                    if (myItem != null)
                    {
                        // Xóa
                        _db.ShoppingCartItems.Remove(myItem);
                        _db.SaveChanges();
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Remove Cart Item - " + exp.Message.ToString(), exp);
                }
            }
        }
        public void UpdateItem(string updateCartID, int updateBookID, int
        quantity)
        {
            using (var _db = new BooksShopOnline.Models.SportContext())
            {
                try
                {
                    var myItem = (from c in _db.ShoppingCartItems
                                  where c.CartId == updateCartID && c.Book.BookID ==
                                  updateBookID
                                  select c).FirstOrDefault();
                    if (myItem != null)
                    {
                        myItem.Quantity = quantity;
                        _db.SaveChanges();
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Update Cart Item - " +
                    exp.Message.ToString(), exp);
                }
            }
        }
        public void EmptyCart()
        {
            ShoppingCartId = GetCartId();
            var cartItems = _db.ShoppingCartItems.Where(
            c => c.CartId == ShoppingCartId);
            foreach (var cartItem in cartItems)
            {
                _db.ShoppingCartItems.Remove(cartItem);
            }
            // cập nhật
            _db.SaveChanges();
        }
        public int GetCount()
        {
            ShoppingCartId = GetCartId();
            // Đếm và tính tổng
            int? count = (from cartItems in _db.ShoppingCartItems
                          where cartItems.CartId == ShoppingCartId
                          select (int?)cartItems.Quantity).Sum();
            // Trả về 0 nếu rỗng
            return count ?? 0;
            return 0;
        }
        public struct ShoppingCartUpdates
        {
            public int SportId;
            public int PurchaseQuantity;
            public bool RemoveItem;
        }

    }
}