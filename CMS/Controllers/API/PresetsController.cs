using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMS.Models;
using CMS.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace CMS.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresetsController : ControllerBase
    {
        private readonly CMSContext _context;
        private readonly IdentityDbContext identityDbContext;
        private UserManager<AppUser> userManager;

        public PresetsController(UserManager<AppUser> userMgr)
        {
            _context = new CMSContext();
            identityDbContext = new IdentityDbContext();
            userManager = userMgr;
        }

        // GET: api/Presets
        [HttpGet]
        public async Task<IActionResult> GetPresetAsync()
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        await RefreshAsync(userInfo);
                        var presetlist =await _context.Preset.AsNoTracking().ToListAsync();
                        var boxlist = await _context.Box.AsNoTracking().ToListAsync();
                        var cardlist = await _context.Card.AsNoTracking().ToListAsync();
                        List<IOformat> ioformatlist = new List<IOformat>();
                        foreach (Preset p in presetlist) {
                            IOformat ioformat = new IOformat();
                            ioformat.presetId = p.presetId;
                            ioformat.presetName = p.presetName;
                            ioformat.themeId = p.themeId;
                            ioformat.visitId = p.visitId;
                            ioformat.dateCreated = p.dateCreated;
                            try
                            {
                                List<Boxformat> boxformatlist = new List<Boxformat>();
                                foreach (Box box in boxlist.Where(b => b.presetId == p.presetId))
                                {
                                    Boxformat boxformat = new Boxformat();
                                    boxformat.boxId = box.boxId;
                                    boxformat.cardList = cardlist.Where(c => c.boxId == box.boxId).ToList();
                                    boxformatlist.Add(boxformat);
                                }
                                ioformat.presetBoxList = boxformatlist;
                                
                            }
                            catch {
                            }
                            ioformatlist.Add(ioformat);
                        }
                        return Ok(ioformatlist);
                    }
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.Message+"\n"+e.StackTrace);
            }
            return null;
            
        }

        // GET: api/Presets/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPreset([FromRoute] int id)
        {
           
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        await RefreshAsync(userInfo);
                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }

                        var preset = await _context.Preset.AsNoTracking().SingleOrDefaultAsync(s=>s.presetId==id);

                        if (preset == null)
                        {
                            return NotFound();
                        }
                        var presetlist = await _context.Preset.AsNoTracking().ToListAsync();
                        var boxlist = await _context.Box.AsNoTracking().ToListAsync();
                        var cardlist = await _context.Card.AsNoTracking().ToListAsync();
                        IOformat ioformat = new IOformat();
                        ioformat.presetId = preset.presetId;
                        ioformat.presetName = preset.presetName;
                        ioformat.themeId = preset.themeId;
                        ioformat.visitId = preset.visitId;
                        ioformat.dateCreated = preset.dateCreated;
                        try
                        {
                            List<Boxformat> boxformatlist = new List<Boxformat>();
                            foreach (Box box in boxlist.Where(b => b.presetId == preset.presetId))
                            {
                                Boxformat boxformat = new Boxformat();
                                boxformat.boxId = box.boxId;
                                boxformat.cardList = cardlist.Where(c => c.boxId == box.boxId).ToList();
                                boxformatlist.Add(boxformat);
                            }
                            ioformat.presetBoxList = boxformatlist;

                        }
                        catch
                        {
                        }
                        return Ok(ioformat);
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
            
        }

        // PUT: api/Presets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPreset([FromRoute] int id, [FromBody] IOformat ioformat)
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        await RefreshAsync(userInfo);
                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }

                        if (id != ioformat.presetId)
                        {
                            return BadRequest();
                        }
                        Preset preset = await _context.Preset.AsNoTracking().SingleAsync(s => s.presetId == ioformat.presetId);
                        if (preset == null)
                        {
                            return BadRequest();
                        }
                        preset.themeId = ioformat.themeId;
                        preset.visitId = ioformat.visitId;
                        preset.presetName = ioformat.presetName;
                        _context.Update(preset);
                        await _context.SaveChangesAsync();
                        //删除所有card和box
                        var boxlist = await _context.Box.AsNoTracking().Where(s => s.presetId == preset.presetId).ToListAsync();
                        foreach (Box box in boxlist)
                        {
                            try
                            {
                                var cardlist = await _context.Card.AsNoTracking().Where(c => c.boxId == box.boxId).ToListAsync();
                                List<Card> cardRemovelist = new List<Card>();
                                foreach (Card card in cardlist)
                                {
                                    cardRemovelist.Add(card);
                                }

                                try
                                {
                                    for (int i = 0; i < cardRemovelist.Count(); i++)
                                    {
                                        _context.Card.Remove(cardRemovelist[i]);
                                        await _context.SaveChangesAsync();
                                    }

                                }
                                catch
                                {
                                }
                            }
                            catch (Exception e)
                            {
                                return BadRequest();
                            }

                        }
                        for (int i = 0; i < boxlist.Count(); i++)
                        {
                            _context.Box.Remove(boxlist[i]);
                            await _context.SaveChangesAsync();
                        }
                        //创建新的box和card
                        foreach (Boxformat boxformat in ioformat.presetBoxList)
                        {
                            var box = new Box();
                            box.presetId = preset.presetId;
                            box.GUID = Guid.NewGuid().ToString();
                            _context.Box.Add(box);
                            await _context.SaveChangesAsync();
                            foreach (Card c in boxformat.cardList)
                            {
                                var box1 = await _context.Box.AsNoTracking().SingleOrDefaultAsync(b => b.presetId == box.presetId && b.GUID == box.GUID);
                                Card card = new Card();
                                card.color = c.color;
                                card.icon = c.icon;
                                card.title = c.title;
                                card.value = c.value;
                                card.boxId = box1.boxId;
                                card.dateCreated = DateTime.Now;
                                _context.Card.Add(card);
                                await _context.SaveChangesAsync();
                            }
                        }

                        //foreach (Boxformat boxformat in ioformat.presetBoxList)
                        //{
                        //    var box = await _context.Box.AsNoTracking().SingleOrDefaultAsync(b => b.boxId == boxformat.boxId);
                        //    if (box != null&& box.presetId == preset.presetId)
                        //    {
                        //        if (box.presetId == preset.presetId)
                        //        {
                        //            foreach (Card c in boxformat.cardList)
                        //            {
                        //                try
                        //                {
                        //                    var chackcard = await _context.Card.AsNoTracking().SingleAsync(s => s.cardId == c.cardId);

                        //                    if (chackcard != null && chackcard.boxId == c.boxId)
                        //                    {
                        //                        chackcard.color = c.color;
                        //                        chackcard.icon = c.icon;
                        //                        chackcard.title = c.title;
                        //                        chackcard.value = c.value;
                        //                        _context.Card.Update(chackcard);
                        //                        await _context.SaveChangesAsync();
                        //                    }


                        //                }
                        //                catch {
                        //                    var box1 = await _context.Box.AsNoTracking().SingleOrDefaultAsync(b => b.presetId == box.presetId && b.GUID == box.GUID);
                        //                    Card card = new Card();
                        //                    card.color = c.color;
                        //                    card.icon = c.icon;
                        //                    card.title = c.title;
                        //                    card.value = c.value;
                        //                    card.boxId = box1.boxId;
                        //                    card.dateCreated = DateTime.Now;
                        //                    _context.Card.Add(card);
                        //                    await _context.SaveChangesAsync();
                        //                }
                        //            }

                        //        }
                        //    }
                        //    else {
                        //            var box2 = new Box();
                        //            box2.presetId = preset.presetId;
                        //            box2.GUID = Guid.NewGuid().ToString();
                        //            _context.Box.Add(box2);
                        //            await _context.SaveChangesAsync();
                        //            foreach (Card c in boxformat.cardList)
                        //            {
                        //            var chackcard = await _context.Card.AsNoTracking().SingleAsync(s => s.cardId == c.cardId);
                        //            if (chackcard != null && chackcard.boxId == c.boxId)
                        //            {
                        //                chackcard.color = c.color;
                        //                chackcard.icon = c.icon;
                        //                chackcard.title = c.title;
                        //                chackcard.value = c.value;
                        //                _context.Card.Update(chackcard);
                        //                await _context.SaveChangesAsync();
                        //            }
                        //            else
                        //            {
                        //                var box1 = await _context.Box.AsNoTracking().SingleOrDefaultAsync(b => b.presetId == box.presetId && b.GUID == box.GUID);
                        //                Card card = new Card();
                        //                card.color = c.color;
                        //                card.icon = c.icon;
                        //                card.title = c.title;
                        //                card.value = c.value;
                        //                card.boxId = box1.boxId;
                        //                card.dateCreated = DateTime.Now;
                        //                _context.Card.Add(card);
                        //                await _context.SaveChangesAsync();
                        //            }
                        //        }


                        //    }
                        //    var oldcardlist = _context.Card.AsNoTracking().Where(c => c.boxId == box.boxId);
                        //    if (oldcardlist.Count() != boxformat.cardList.Count())
                        //    {
                        //        List<Card> removecardlist = new List<Card>();
                        //        foreach (Card oldcard in oldcardlist)
                        //        {
                        //            bool flag = false;
                        //            foreach (Card card in boxformat.cardList)
                        //            {
                        //                if (oldcard.cardId == card.cardId)
                        //                {
                        //                    flag = true;
                        //                    break;
                        //                }
                        //            }
                        //            if (flag == false)
                        //            {
                        //                removecardlist.Add(oldcard);

                        //            }
                        //        }
                        //        //foreach(Card card in removecardlist)
                        //        //{
                        //        //    _context.Card.AsNoTracking();
                        //        //    _context.Card.Remove(card);
                        //        //    await _context.SaveChangesAsync();
                        //        //}
                        //        try
                        //        {
                        //            for (int i = 0; i < removecardlist.Count(); i++)
                        //            {
                        //                _context.Card.Remove(removecardlist[i]);
                        //                await _context.SaveChangesAsync();
                        //            }
                        //        }
                        //        catch
                        //        {
                        //        }
                        //    }
                        //}//为了提高程序的容错率删除box只能用api操作
                        APIReturn re = new APIReturn();
                        re.Status = "success";
                        return Ok(re);
                    }
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.Message+"\n"+e.StackTrace);
            }
            return null;
            
        }
        // POST: api/Presets
        [HttpPost]
        public async Task<IActionResult> PostPreset([FromBody] IOformat ioformat)
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                       
                        await RefreshAsync(userInfo);
                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }
                        try
                        {
                            var preset = new Preset();
                            preset.dateCreated = DateTime.Now;
                            preset.themeId = ioformat.themeId;
                            preset.visitId = ioformat.visitId;
                            preset.presetName = ioformat.presetName;
                            _context.Preset.Add(preset);
                            await _context.SaveChangesAsync();

                            foreach (Boxformat boxformat in ioformat.presetBoxList)
                            {
                                var box = new Box();
                                box.presetId = preset.presetId;
                                box.GUID = Guid.NewGuid().ToString();
                                _context.Box.Add(box);
                                await _context.SaveChangesAsync();
                                foreach (Card c in boxformat.cardList)
                                {
                                    var box1 = await _context.Box.AsNoTracking().SingleOrDefaultAsync(b=>b.presetId==box.presetId&&b.GUID==box.GUID);
                                    Card card = new Card();
                                    card.color = c.color;
                                    card.icon = c.icon;
                                    card.title = c.title;
                                    card.value = c.value;
                                    card.boxId = box1.boxId;
                                    card.dateCreated = DateTime.Now;
                                    _context.Card.Add(card);
                                    await _context.SaveChangesAsync();
                                }
                            }
                            APIReturn re = new APIReturn();
                            re.Status = "success";
                            return Ok(re);
                        }
                        catch(Exception e) {
                            return BadRequest(e.Message+"\n"+e.StackTrace);
                        }
                        
                    }
                }
            }
            catch(Exception e)
            {
                return BadRequest("2."+e.Message);
            }
            return BadRequest();
            
        }

        // DELETE: api/Presets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePreset([FromRoute] int id)
        {
            
            try
            {
                string key = HttpContext.Request.Headers["Key"];
                if (key != null)
                {
                    UserInfo userInfo = identityDbContext.AspNetUsers.Single(s => s.UserKey == key);
                    if (userInfo != null)
                    {
                        await RefreshAsync(userInfo);
                        if (!ModelState.IsValid)
                        {
                            return BadRequest(ModelState);
                        }

                        var preset = await _context.Preset.AsNoTracking().SingleAsync(s=>s.presetId==id);
                        if (preset == null)
                        {
                            return NotFound();
                        }
                        var boxlist =await _context.Box.AsNoTracking().Where(s => s.presetId == preset.presetId).ToListAsync();
                        foreach(Box box in boxlist)
                        {
                            try
                            {
                                var cardlist =await _context.Card.AsNoTracking().Where(c => c.boxId == box.boxId).ToListAsync();
                                List<Card> cardRemovelist = new List<Card>();
                                foreach (Card card in cardlist)
                                {
                                    cardRemovelist.Add(card);
                                }
                           
                            try
                            {
                                for(int i = 0; i < cardRemovelist.Count(); i++)
                                {
                                    _context.Card.Remove(cardRemovelist[i]);
                                    await _context.SaveChangesAsync();
                                }

                            }
                            catch {
                            }
                            }
                            catch (Exception e)
                            {
                                return BadRequest();
                            }

                        }
                        for (int i = 0; i < boxlist.Count(); i++)
                        {
                            _context.Box.Remove(boxlist[i]);
                            await _context.SaveChangesAsync();
                        }
                        _context.Preset.Remove(preset);
                        await _context.SaveChangesAsync();
                        
                        APIReturn re = new APIReturn();
                        re.Status = "success";
                        return Ok(re);
                    }
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.Message+"\n\n"+e.StackTrace);
            }
            return null;
            
        }

        private bool PresetExists(int id)
        {
            return _context.Preset.Any(e => e.presetId == id);
        }

        private static string MakeKey(int pwdLength)

        {     //声明要返回的字符串    

            string tmpstr = "";

            //密码中包含的字符数组    

            string pwdchars = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()_?/-=";

            //数组索引随机数    

            int iRandNum;

            //随机数生成器    

            Random rnd = new Random();

            for (int i = 0; i < pwdLength; i++)

            {      //Random类的Next方法生成一个指定范围的随机数     

                iRandNum = rnd.Next(pwdchars.Length);

                //tmpstr随机添加一个字符     

                tmpstr += pwdchars[iRandNum];

            }

            return tmpstr;
        }

        public async Task RefreshAsync(UserInfo userInfo)
        {
            AppUser user = await userManager.FindByNameAsync(userInfo.UserName);
            user.UserKey = MakeKey(15);
            IdentityResult result2 = await userManager.UpdateAsync(user);
        }
    }

    public class IOformat {
        public int presetId { get; set; }
        public int themeId { get; set; }
        public int visitId { get; set; }
        public string presetName { get; set; }
        public DateTime dateCreated { get; set; }
        public List<Boxformat> presetBoxList { get; set; }
    }
    public class Boxformat {
        public int boxId { get; set; }
        public List<Card> cardList { get; set; }
    }
}