using ATMSystem.Business.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ATMSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;
        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }
        [HttpGet("{cardNumber}/{password}")]
        public IActionResult GetCardInfo(long cardNumber, int password)
        {
            try 
            {
                var result = _cardService.GetCardInfo(cardNumber, password);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        //[HttpPost]
        //public IActionResult GetMoneyFromCard([FromForm] long cardNumber, int password, decimal sum)
        //{
        //    try
        //    {
        //        _cardService.GetMoneyFromCard(cardNumber, password, sum);
        //        return Ok("Operation was succesfull");
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex.Message);
        //    }
        //}
        //[HttpPost]
        //public IActionResult GetMoneyOnCard([FromForm] long cardNumber, int password, decimal sum)
        //{
        //    try
        //    {
        //        _cardService.GetMoneyOnCard(cardNumber, password, sum);
        //        return Ok("Operation was succesfull");
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex.Message);
        //    }
        //}
    }
}
