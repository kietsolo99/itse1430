/*
 * ITSE 1430
 * Character Roster
 * Kiet Vo
 * Lab 5
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CharacterCreator.Memory;
using CharacterCreator.Web.Models;

namespace CharacterCreator.Web.Controllers
{
    public class CharacterController : Controller
    {

        // GET: Character
        public ActionResult Index()
        {
            var characters = _database.GetAll();

            var model = characters.Select(x => new CharacterModel(x))
                  .OrderBy(x => x.Name);


            return View("List", model);
        }

        // GET: Details/{id}
        public ActionResult Details ( int id )
        {
            var character = _database.Get(id);
            if (character == null)
                return HttpNotFound(); //404

            return View(new CharacterModel(character));
        }

        // GET: Edit/{id}
        public ActionResult Edit ( int id )
        {
            var character = _database.Get(id);
            if (character == null)
                return HttpNotFound(); //404

            return View(new CharacterModel(character));
        }

        // POST: Edit
        [HttpPost]
        public ActionResult Edit ( CharacterModel model )
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _database.Update(model.Id, model.ToCharacter());

                    return RedirectToAction(nameof(Details), new { id = model.Id });
                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            };

            return View(model);
        }

        // GET: Create
        public ActionResult Create () => View(new CharacterModel());

        // POST: Create
        [HttpPost]
        public ActionResult Create ( CharacterModel model )
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var character = _database.Add(model.ToCharacter());

                    return RedirectToAction(nameof(Details), new { id = character.Id });
                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            };

            return View(model);
        }

        // GET: Delete/{id}
        public ActionResult Delete ( int id )
        {
            var character = _database.Get(id);
            if (character == null)
                return HttpNotFound(); //404

            return View(new CharacterModel(character));
        }

        // POST: Delete
        [HttpPost]
        public ActionResult Delete ( CharacterModel model )
        {
            try
            {
                _database.Delete(model.Id);

                return RedirectToAction(nameof(Index));
            } catch (Exception e)
            {
                //NEVER USE THIS - IT DOESN'T WORK
                //ModelState.AddModelError("", e);
                ModelState.AddModelError("", e.Message);
            };

            return View(model);
        }

        private readonly static ICharacterRoster _database = new MemoryCharacterRoster();


    }
}