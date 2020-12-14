using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TransportCardController : BaseApiController
    {
        private readonly ITransportCardRepository _transportCardRepository;
        private readonly IMapper _mapper;

        public TransportCardController(ITransportCardRepository transportCardRepository, IMapper mapper)
        {
            _transportCardRepository = transportCardRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransportCardDto>>> GetTransportCards()
        {
            var cards = await _transportCardRepository.GetTransportCardsAsync();

            var cardsViewModel = _mapper.Map<IEnumerable<TransportCardDto>>(cards);

            return Ok(cardsViewModel);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TransportCardDto>> GetTransportCard(int id)
        {
            var card = await _transportCardRepository.GetTransportCardByIdAsync(id);
            var cardViewModel = _mapper.Map<TransportCardDto>(card);
            return cardViewModel;
        }
    }
}