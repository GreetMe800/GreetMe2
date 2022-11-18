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
        private readonly IMenuRepository _menuRepository;
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

        //Create Menu - api/Menus
        [HttpPost]
        public async Task<Menu> Create([FromBody] MenuDto menuDto)
        {
            if (ModelState.IsValid)
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
            throw new NotImplementedException();
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