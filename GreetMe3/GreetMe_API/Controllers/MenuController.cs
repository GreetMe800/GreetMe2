using GreetMe_API;
using GreetMe_API.DTO;
using GreetMe_API.ModelConverter;
using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using GreetMe_DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GreetMe_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : Controller
    {
        private readonly IMenuRepository _menuRepository; //test
        [ActivatorUtilitiesConstructor]
        public MenuController(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }
        //-----------------------------------------------------------------------------
        /* GetAll                                                                    */
        //-----------------------------------------------------------------------------

        //GetAll Async
        [HttpGet(Name = "GetAllMenusAsync")]
        public IEnumerable<Menu> GetAll()
        {
            return _menuRepository.GetAll();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get - api/Menus/5
        [HttpGet("{id}")]
        public async Task<MenuDto> Get(int id)
        {
            Menu foundMenu = _menuRepository.Get(id);
            MenuDto menuDto = MenuDtoConverter.ConvertToDto(foundMenu);
            return menuDto;
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                              */
        //-----------------------------------------------------------------------------

<<<<<<< HEAD
        //Create View
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] MenuDto menuDto)
        {
            Menu menu = MenuDtoConverter.ConvertFromDto(menuDto);
            Menu menuCreated = await _menuRepository.CreateAsync(menu);
            if (menuCreated is not null)
=======
        //Create Menu - api/Menus
        [HttpPost]
        public async Task<Menu> Create([FromBody] MenuDto menuDto)
        {
            if (ModelState.IsValid)
>>>>>>> Main_Sprint_3_asp_Spike
            {
                Menu menu = MenuDtoConverter.ConvertToModel(menuDto);
                return await _menuRepository.CreateAsync(menu);
            }
            return null;
        }

        //Update Async
        [HttpPut]
        public async Task<ActionResult> Update(MenuDto menuDto)
        {
<<<<<<< HEAD
            Menu menu = MenuDtoConverter.ConvertFromDto(menuDto);
            Menu menuUpdated = await _menuRepository.UpdateAsync(menu);
            if (menuUpdated is null)
            {
                return Ok();
            }
            else
            {
                return Conflict();
            }
=======
            throw new NotImplementedException();
>>>>>>> Main_Sprint_3_asp_Spike
        }

        //-----------------------------------------------------------------------------
        /* Delete                                                                    */
        //-----------------------------------------------------------------------------

        //Delete Async
        [HttpDelete]
        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}