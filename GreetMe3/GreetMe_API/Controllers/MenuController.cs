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
        public IEnumerable<Menu> GetAllAsync()
        {
            return _menuRepository.GetAll();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get By Id
        [HttpGet, Route("id")]
        public ActionResult<MenuDto> GetById(int id)
        {
            //Input validator, 0 <
            if (id <= 0)
            {
                return Conflict();
            }

            Menu? foundMenu = _menuRepository.Get(id);

            //if menu is found
            if (foundMenu is not null)
            {
                MenuDto menuDto = MenuDtoConverter.ConvertToDto(foundMenu);
                return Ok(menuDto);
            }

            //if not found
            else
            {
                return Conflict();
            }
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                              */
        //-----------------------------------------------------------------------------

        //Create View
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] MenuDto menuDto)
        {
            Menu menu = MenuDtoConverter.ConvertFromDto(menuDto);
            Menu menuCreated = await _menuRepository.CreateAsync(menu);
            if (menuCreated is not null)
            {
                return Ok();
            }
            else
            {
                return Conflict();
            }
        }

        //Update Async
        [HttpPut]
        public async Task<ActionResult> Update(MenuDto menuDto)
        {
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
        }

        //-----------------------------------------------------------------------------
        /* Delete                                                                    */
        //-----------------------------------------------------------------------------

        //Delete Async
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            bool menuDeleted = await _menuRepository.DeleteAsync(id);
            if (menuDeleted)
            {
                return Ok();
            }
            else
            {
                return Conflict();
            }
        }
    }
}