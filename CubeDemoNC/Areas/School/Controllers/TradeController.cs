using System.ComponentModel;
using NewLife.Cube;
using NewLife.School.Entity;

namespace WebTest.Areas.School.Controllers
{
    [SchoolArea]
    [DisplayName("交易")]
    public class TradeController : EntityController<Trade>
    {
    }
}