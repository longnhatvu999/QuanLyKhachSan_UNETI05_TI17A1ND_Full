// ============================================================
// Họ và tên: [Tên SV1]
// Mã sinh viên: [Mã SV1]
// Nội dung thực hiện: Trang chủ của hệ thống
// Module: 1
// Lớp: TI17A1ND - Nhóm 05
// ============================================================

using Microsoft.AspNetCore.Mvc;

namespace QuanLyKhachSan_UNETI05_TI17A1ND.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}