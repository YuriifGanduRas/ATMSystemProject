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
        [HttpGet]
        public IActionResult GetAllCards()
        {
            try
            {
                var result = _cardService.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetCardById(int id)
        {
            try
            {
                var result = _cardService.GetById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
