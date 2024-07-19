using Microsoft.VisualBasic;
using NET1806_LittleJoy.Repository.Commons;
using NET1806_LittleJoy.Service.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NET1806_LittleJoy.Service.Helpers
{
    public class EmailContent
    {
        public static string EmailOTPContent(string username, int otp)
        {
            return "<div style=\"background-color:#f8f8f8;font-family:sans-serif;padding:15px\">\n"
                + "    <div style=\"max-width:1000px;margin:auto\">\n"
                + "<div\n" +
"                style=\"background-color:#fff;padding:5px 20px;border-radius:10px; margin-bottom: 20px;display: flex;justify-content: center;\">\n" +
"                <div style=\"display: inline-block; width: 15%;\"><a href=\"https://littlejoy.vercel.app/\"><img\n" +
"                            src=\"https://firebasestorage.googleapis.com/v0/b/little-joy-2c5d3.appspot.com/o/Logo%20Little%20Joy%20Store.png?alt=media&token=c0752ee7-f2c0-400e-9024-632160b7aa66\"\n" +
"                            alt=\"\" style=\"width: 100%;\"></a></div>\n" +
"                <div style=\"display: inline-block; width: 85%;\">\n" +
"                    <table style=\"width: 100%; height: 100%;\">\n" +
"                        <tr style=\"height: 33%; width: 33%;\">\n" +
"                            <td></td>\n" +
"                            <td></td>\n" +
"                            <td></td>\n" +
"                        </tr>\n" +
"                        <tr style=\"height: 33%;\">\n" +
"                            <td colspan=\"3\" style=\"text-align: center;\">\n" +
"                                <span style=\"font-size: 22px; color: #3C75A6; font-weight: 600;\">\n" +
"                                    Little Joy Store - Cửa Hàng Sữa Cho Mẹ Bầu Và Em Bé\n" +
"                                </span>\n" +
"                            </td>\n" +
"                        </tr>\n" +
"                        <tr style=\"height: 33%;\">\n" +
"                            <td></td>\n" +
"                            <td></td>\n" +
"                        </tr>\n" +
"                    </table>\n" +
"                </div>\n" +
"            </div>\n"
                + "        <div class=\"adM\">\n"
                + "            <div style=\"background-color:#fff;padding:5px 20px;color:#000;border-radius:0px 0px 2px 2px\">\n"
                + "                <div style=\"padding:35px 15px\">\n"
                + "                    <p style=\"margin:0;font-size:16px\">\n"
                + "                        <b>Xin chào, " + username + "</b>\n"
                + "                    </p>\n"
                + "                    <br>\n"
                + "                    <p style=\"margin:0;font-size:16px\">\n"
                + "                        Bạn vừa nhận được mã\n"
                + "                        <span class=\"il\">OTP</span>\n"
                + "                        xác nhận tại\n"
                + "                        <a style=\"text-decoration:none\" href=\"#\" target=\"_blank\">Little Joy Store</a>\n"
                + "                    </p>\n"
                + "                    <div style=\"padding:40px;margin:auto;text-align:center\">\n"
                + "                        <div style=\"width:fit-content;border:#3cc892 thin solid;color:#3cc892;font-weight:bold;text-align:center;padding:7px 12px;border-radius:2px;margin:auto;font-size:large\">" + otp + "</div>\n"
                + "                    </div>\n"
                + "                    <div style=\"border-top:1px solid #dcdbdb\"></div>\n"
                + "                    <br>\n"
                + "                    <p style=\"margin:0;font-size:16px\">\n"
                + "                        Nếu bạn không thực hiện yêu cầu này, xin vui lòng bỏ qua nó hoặc nếu cần hỗ trợ, liên hệ với chúng tôi\n"
                + "                        <a style=\"text-decoration:none\" href=\"#\" target=\"_blank\">ngay</a>\n"
                + "                        .\n"
                + "                    </p>\n"
                + "                    <br>\n"
                + "                    <p style=\"margin:0;font-size:16px\">Trân trọng,</p>\n"
                + "                    <p style=\"margin:0;font-size:16px\">Little Joy Store Team.</p>\n"
                + "                </div>\n"
                + "            </div>\n"
                + "        </div>\n"
                + "    </div>\n"
                + "</div>";
        }

        public static string ConfirmEmail(string username, string tokenConfirm)
        {
            return "<div style=\"background-color:#f8f8f8;font-family:sans-serif;padding:15px\">\n"
                + "        <div style=\"max-width:1000px ; margin:auto\">\n"
                + "<div\n" +
"                style=\"background-color:#fff;padding:5px 20px;border-radius:10px; margin-bottom: 20px;display: flex;justify-content: center;\">\n" +
"                <div style=\"display: inline-block; width: 15%;\"><a href=\"https://littlejoy.vercel.app/\"><img\n" +
"                            src=\"https://firebasestorage.googleapis.com/v0/b/little-joy-2c5d3.appspot.com/o/Logo%20Little%20Joy%20Store.png?alt=media&token=c0752ee7-f2c0-400e-9024-632160b7aa66\"\n" +
"                            alt=\"\" style=\"width: 100%;\"></a></div>\n" +
"                <div style=\"display: inline-block; width: 85%;\">\n" +
"                    <table style=\"width: 100%; height: 100%;\">\n" +
"                        <tr style=\"height: 33%; width: 33%;\">\n" +
"                            <td></td>\n" +
"                            <td></td>\n" +
"                            <td></td>\n" +
"                        </tr>\n" +
"                        <tr style=\"height: 33%;\">\n" +
"                            <td colspan=\"3\" style=\"text-align: center;\">\n" +
"                                <span style=\"font-size: 22px; color: #3C75A6; font-weight: 600;\">\n" +
"                                    Little Joy Store - Cửa Hàng Sữa Cho Mẹ Bầu Và Em Bé\n" +
"                                </span>\n" +
"                            </td>\n" +
"                        </tr>\n" +
"                        <tr style=\"height: 33%;\">\n" +
"                            <td></td>\n" +
"                            <td></td>\n" +
"                        </tr>\n" +
"                    </table>\n" +
"                </div>\n" +
"            </div>\n"
                + "            <div class=\"adM\">\n"
                + "                <div style=\"background-color:#fff;padding:5px 20px;color:#000;border-radius:0px 0px 2px 2px\">\n"
                + "                    <div style=\"padding:35px 15px\">\n"
                + "                        <p style=\"margin:0;font-size:16px\">\n"
                + "                            <b>Xin chào, " + username + " </b>\n"
                + "                        </p>\n"
                + "                        <br>\n"
                + "                        <p style=\"margin:0;font-size:16px\">\n"
                + "                            Bạn vừa đăng kí tài khoản, vui lòng ấn vào nút dưới đây để xác nhận tài khoản tại\n"
                + "                            <a style=\"text-decoration:none\\\\\" href=\"https://littlejoy.vercel.app\\\\\"\n"
                + "                                target=\"_blank\">Little Joy Store</a>\n"
                + "                        </p>\n"
                + "                        <div style=\"padding:40px;margin:auto;text-align:center\">\n"
                + "                            <a href=\"https://littlejoy.vercel.app/confirm/" + tokenConfirm + "\"\n"
                + "                                style=\"color: #3cc892; text-decoration: none;\">\n"
                + "                                <div\n"
                + "                                    style=\"width:fit-content;border:#3cc892 thin solid;color:#3cc892;font-weight:bold;text-align:center;padding:7px 12px;border-radius:2px;margin:auto;font-size:large\">\n"
                + "                                    XÁC NHẬN\n"
                + "                                </div>\n"
                + "                            </a>\n"
                + "                        </div>\n"
                + "                        <div style=\"border-top:1px solid #dcdbdb\"></div>\n"
                + "                        <br>\n"
                + "                        <p style=\"margin:0;font-size:16px\">Trân trọng,</p>\n"
                + "                        <p style=\"margin:0;font-size:16px\">Little Joy Store Team.</p>\n"
                + "                    </div>\n"
                + "                </div>\n"
                + "            </div>\n"
                + "        </div>\n"
                + "    </div>";
        }

        public static string WelcomeEmail(string username)
        {
            return "<div style=\"background-color:#f8f8f8;font-family:sans-serif;padding:15px\">\n"
                + "        <div style=\"max-width:1000px ; margin:auto\">\n"
                + "            <div class=\"adM\">\n"
                + "                <div style=\"background-color:#fff;padding:5px 20px;color:#000;border-radius:0px 0px 2px 2px\">\n"
                + "                    <div style=\"padding:35px 15px;\">\n"
                + "                        <div style=\"display: flex; justify-content: center; align-items: center;\">\n"
                + "                            <div style=\"width: 10%;\">\n"
                + "                                <a href=\"https://littlejoy.vercel.app/\"><img\n"
                + "                                    src=\"https://firebasestorage.googleapis.com/v0/b/little-joy-2c5d3.appspot.com/o/Logo%20Little%20Joy%20Store.png?alt=media&token=c0752ee7-f2c0-400e-9024-632160b7aa66\"\n"
                + "                                    alt=\"\" style=\"width: 100%\"></a>\n"
                + "                            </div>\n"
                + "                            <span style=\"font-size: 25px; color: #005B96; font-weight: 600; padding-left: 20px;\">Chào mừng bạn đến với\n"
                + "                                Little Joy Store</span>\n"
                + "                        </div>\n"
                + "                        <div style=\"margin-top: 20px; font-size: 16px;\">\n"
                + "                            <p><strong>Xin chào " + username + ",</strong></p>\n"
                + "                            <span>Cảm ơn bạn đã đăng ký tài khoản tại <span style=\"color: #1A469E; font-weight: 600;\">Little Joy Store</span>. Chúng tôi rất vui mừng được chào đón bạn đến với cộng đồng của chúng tôi.</span><br>\n"
                + "                            <p style=\"margin-top: 15px; margin-bottom: 15px;\">Tại đây, bạn sẽ tìm thấy:</p>\n"
                + "                            <ul>\n"
                + "                                <li><strong>Các loại sữa chất lượng cao:</strong> Đảm bảo an toàn và dinh dưỡng cho cả mẹ và bé.</li>\n"
                + "                                <li><strong>Ưu đãi đặc biệt:</strong> Các ưu đãi thường xuyên được cập nhật</li>\n"
                + "                                <li><strong>Tư vấn miễn phí:</strong> Giúp bạn chọn sản phẩm phù hợp.</li>\n"
                + "                                <li>Và rất nhiều tiện ích khác ...</li>\n"
                + "                            </ul>\n"
                + "                            <p>Hãy bắt đầu khám phá ngay các sản phẩm và chương trình khuyến mãi hấp dẫn từ chúng tôi.</p>\n"
                + "                            <p>Nếu bạn cần bất kỳ sự hỗ trợ nào, vui lòng liên hệ với chúng tôi qua <a href=\"#\" style=\"text-decoration: none; color: #004574; font-weight: 600;\">Little Joy Team</a></p>\n"
                + "                            <p>Chúc bạn và gia đình luôn khỏe mạnh và hạnh phúc!</p>\n"
                + "                            <p style=\"margin:0;font-size:16px;font-weight: 600;\">Trân trọng,</p>\n"
                + "                            <p style=\"margin:0;font-size:16px;font-weight: 600;\">Little Joy Store Team.</p>\n"
                + "                        </div>\n"
                + "\n"
                + "                    </div>\n"
                + "                </div>\n"
                + "            </div>\n"
                + "        </div>\n"
                + "    </div>";

        }

        public static string OrderEmail(OrderWithDetailsModel model, UserModel user)
        {
            string address = model.Address;
            if (address.Length > 30)
            {
                address = address.Substring(0, 30) + "...";
            }

            string infoDetails = "";
            int count = 1;
            foreach (var item in model.ProductOrders)
            {
                infoDetails += "                            <tr>\n" +
"                                <td style=\"border: 1px solid gray;padding: 7px 10px; text-align: center;\">" + count++ + "</td>\n" +
"                                <td style=\"border: 1px solid gray; padding-left: 7px ;\"><span>" + item.ProductName + "</span>\n" +
"                                </td>\n" +
"                                <td style=\"border: 1px solid gray; padding-right: 7px ;\"><span\n" +
"                                        style=\"float: inline-end;\">" + item.Quantity + "</span></td>\n" +
"                                <td style=\"border: 1px solid gray; padding-right: 7px ;\"><span\n" +
"                                        style=\"float: inline-end;\">" + (item.Price / item.Quantity).ToString("N0") + "</span></td>\n" +
"                                <td style=\"border: 1px solid gray; padding-right: 7px ;\"><span\n" +
"                                        style=\"float: inline-end;\">" + item.Price.ToString("N0") + "</span></td>\n" +
"                            </tr>\n";
            }

            if (model.AmountDiscount != 0)
            {
                int amount = (int)model.AmountDiscount;
                infoDetails += "                            <tr>\n" +
"                                <td style=\"border: 1px solid gray;padding: 7px 10px; text-align: center;\">" + count++ + "</td>\n" +
"                                <td style=\"border: 1px solid gray; padding-left: 7px ;\"><span>Giảm giá</span></td>\n" +
"                                <td style=\"border: 1px solid gray; padding-right: 7px ;\"><span\n" +
"                                        style=\"float: inline-end;\"></span></td>\n" +
"                                <td style=\"border: 1px solid gray; padding-right: 7px ;\"><span\n" +
"                                        style=\"float: inline-end;\"></span></td>\n" +
"                                <td style=\"border: 1px solid gray; padding-right: 7px ;\"><span\n" +
"                                        style=\"float: inline-end;\">- " + amount.ToString("N0") + "</span></td>\n" +
"                            </tr>\n";
            }
            return "<div style=\"background-color:#f8f8f8;font-family:sans-serif;padding:15px\">\n" +
"        <div style=\"max-width:1000px ; margin:auto\">\n" +
"            <div\n" +
"                style=\"background-color:#fff;padding:5px 20px;border-radius:10px; margin-bottom: 20px;display: flex;justify-content: center;\">\n" +
"                <div style=\"display: inline-block; width: 15%;\"><a href=\"https://littlejoy.vercel.app/\"><img\n" +
"                            src=\"https://firebasestorage.googleapis.com/v0/b/little-joy-2c5d3.appspot.com/o/Logo%20Little%20Joy%20Store.png?alt=media&token=c0752ee7-f2c0-400e-9024-632160b7aa66\"\n" +
"                            alt=\"\" style=\"width: 100%;\"></a></div>\n" +
"                <div style=\"display: inline-block; width: 85%;\">\n" +
"                    <table style=\"width: 100%; height: 100%;\">\n" +
"                        <tr style=\"height: 33%; width: 33%;\">\n" +
"                            <td></td>\n" +
"                            <td></td>\n" +
"                            <td></td>\n" +
"                        </tr>\n" +
"                        <tr style=\"height: 33%;\">\n" +
"                            <td colspan=\"3\" style=\"text-align: center;\">\n" +
"                                <span style=\"font-size: 22px; color: #3C75A6; font-weight: 600;\">\n" +
"                                    Little Joy Store - Cửa Hàng Sữa Cho Mẹ Bầu Và Em Bé\n" +
"                                </span>\n" +
"                            </td>\n" +
"                        </tr>\n" +
"                        <tr style=\"height: 33%;\">\n" +
"                            <td></td>\n" +
"                            <td></td>\n" +
"                        </tr>\n" +
"                    </table>\n" +
"                </div>\n" +
"            </div>\n" +
"            <div style=\"background-color:#fff;padding:5px 20px;color:#000;border-radius:10px\">\n" +
"                <div style=\"padding:35px 15px\">\n" +
"                    <p style=\"margin:0;font-size:16px; padding-bottom: 10px;\">\n" +
"                        <b>Kính chào quý khách,</b>\n" +
"                    </p>\n" +
"                    <p style=\"margin:0;font-size:16px\">\n" +
"                        Chúng tôi trân trọng thông báo rằng đơn hàng của quý khách đã được đặt hàng thành công\n" +
"                    </p>\n" +
"                    <br>\n" +
"                    <div style=\"border-top:1px solid #dcdbdb\"></div>\n" +
"                    <div style=\"display: flex; justify-content: center; margin-top: 20px;\">\n" +
"                        <div style=\"display: inline-block; width: 50%; padding: 10px;\">\n" +
"                            <table style=\"width: 100%; table-layout: auto; font-size: 16px;\">\n" +
"                                <tr>\n" +
"                                    <td colspan=\"2\" style=\"font-weight: 600; padding: 10px 0; font-size: 18px;\">THÔNG\n" +
"                                        TIN KHÁCH HÀNG</td>\n" +
"                                </tr>\n" +
"                                <tr>\n" +
"                                    <td style=\"width: 40%; padding: 10px 0;\">Tên khách hàng :</td>\n" +
"                                    <td style=\"width: 60%;\"><span>" + user.Fullname + "</span></td>\n" +
"                                </tr>\n" +
"                                <tr>\n" +
"                                    <td style=\"padding: 10px 0;\">Địa chỉ giao hàng :</td>\n" +
"                                    <td><span>" + address + "</span></td>\n" +
"                                </tr>\n" +
"                                <tr>\n" +
"                                    <td style=\"padding: 10px 0;\">Số điện thoại :</td>\n" +
"                                    <td><span>" + user.PhoneNumber + "</span></td>\n" +
"                                </tr>\n" +
"                                <tr>\n" +
"                                    <td style=\"padding: 10px 0;\">Email :</td>\n" +
"                                    <td><span>" + user.Email + "</span></td>\n" +
"                                </tr>\n" +
"                            </table>\n" +
"                        </div>\n" +
"                        <div style=\"display: inline-block; width: 50%; padding: 10px;\">\n" +
"                            <table style=\"width: 100%; table-layout: auto; font-size: 16px;\">\n" +
"                                <tr>\n" +
"                                    <td colspan=\"2\" style=\"font-weight: 600; padding: 10px 0; font-size: 18px;\">THÔNG\n" +
"                                        TIN ĐƠN HÀNG</td>\n" +
"                                </tr>\n" +
"                                <tr>\n" +
"                                    <td style=\"width: 40%; padding: 10px 0;\">Mã đơn hàng :</td>\n" +
"                                    <td style=\"width: 60%;\">#" + model.OrderCode + "</td>\n" +
"                                </tr>\n" +
"                                <tr>\n" +
"                                    <td style=\"padding: 10px 0;\">Tổng tiền :</td>\n" +
"                                    <td><span>" + model.TotalPrice.ToString("N0") + "</span></td>\n" +
"                                </tr>\n" +
"                                <tr>\n" +
"                                    <td style=\"padding: 10px 0;\">Phương thức :</td>\n" +
"                                    <td><span>" + model.PaymentMethod + "</span></td>\n" +
"                                </tr>\n" +
"                                <tr>\n" +
"                                    <td style=\"padding: 10px 0;\">Ngày tạo hóa đơn: </td>\n" +
"                                    <td><span>" + model.date.ToString("dd/MM/yyyy") + "</span></td>\n" +
"                                </tr>\n" +
"                            </table>\n" +
"                        </div>\n" +
"                    </div>\n" +
"                    <br>\n" +
"                    <div style=\"border-top:1px solid #dcdbdb\"></div>\n" +
"                    <div style=\"padding: 10px; margin-top: 20px;\">\n" +
"                        <table\n" +
"                            style=\"width: 100%; border-collapse: collapse; border: 1px solid gray; color: #000; font-size: 16px;\">\n" +
"                            <tr style=\"background-color: #3C75A6; color: white;\">\n" +
"                                <td style=\"width: 9%; padding: 5px 10px; text-align: center; border: 1px solid gray;\">\n" +
"                                    STT</td>\n" +
"                                <td style=\"width: 28%;text-align: center; border: 1px solid gray;\">MẶT HÀNG</td>\n" +
"                                <td style=\"width: 20%;text-align: center; border: 1px solid gray;\">SỐ LƯỢNG</td>\n" +
"                                <td style=\"width: 15%;text-align: center; border: 1px solid gray;\">ĐƠN GIÁ</td>\n" +
"                                <td style=\"width: 28%;text-align: center; border: 1px solid gray;\">THÀNH TIỀN (VNĐ)</td>\n" +
"                            </tr>\n" + infoDetails +
"                            <tr style=\"background-color: #3C75A6; color: white;\">\n" +
"                                <td colspan=\"4\" style=\"padding: 5px 10px; border: 1px solid gray;\">TỔNG TIỀN (VNĐ)</td>\n" +
"                                <td style=\"text-align: center; border: 1px solid gray; padding-right: 7px ;\"><span\n" +
"                                        style=\"float: inline-end;\">" + model.TotalPrice.ToString("N0") + "</span></td>\n" +
"                            </tr>\n" +
"                        </table>\n" +
"                    </div>\n" +
"                    <br>\n" +
"                    <div style=\"border-top:1px solid #dcdbdb\"></div>\n" +
"                    <p style=\"margin:0;font-size:16px; margin-top: 10px;\">Trân trọng,</p>\n" +
"                    <p style=\"margin:0;font-size:16px\">Little Joy Store Team.</p>\n" +
"                </div>\n" +
"            </div>\n" +
"        </div>\n" +
"    </div>";
        }


        public static string NotificationEmail(UserModel? user, PaymentModel? model, OrderModel order, string reason)
        {
            return "<div style=\"background-color:#f8f8f8;font-family:sans-serif;padding:15px\">\n" +
    "            <div style=\"max-width:1000px;margin:auto\">\n" +
    "        <div style=\"background-color:#fff;padding:5px 20px;border-radius:10px; margin-bottom: 20px;display: flex;justify-content: center;\">\n" +
    "                <div style=\"display: inline-block; width: 15%;\"><a href=\"https://littlejoy.vercel.app/\"><img \n" +
    "                            src=\"https://firebasestorage.googleapis.com/v0/b/little-joy-2c5d3.appspot.com/o/Logo%20Little%20Joy%20Store.png?alt=media&token=c0752ee7-f2c0-400e-9024-632160b7aa66\"\n" +
    "                            alt=\"\" style=\"width: 100%;\"></a></div> \n" +
    "                <div style=\"display: inline-block; width: 85%;\"> \n" +
    "                   <table style=\"width: 100%; height: 100%;\"> \n" +
    "                        <tr style=\"height: 33%; width: 33%;\">\n" +
    "                            <td></td> \n" +
    "                            <td></td> \n" +
    "                            <td></td> \n" +
    "                        </tr>\n" +
    "                        <tr style=\"height: 33%;\"> \n" +
    "                            <td colspan=\"3\" style=\"text-align: center;\"> \n" +
    "                                <span style=\"font-size: 22px; color: #3C75A6; font-weight: 600;\"> \n" +
    "                                    Little Joy Store - Cửa Hàng Sữa Cho Mẹ Bầu Và Em Bé \n" +
    "                                </span> \n" +
    "                            </td> \n" +
    "                        </tr> \n" +
    "                        <tr style=\"height: 33%;\"> \n" +
    "                            <td></td> \n" +
    "                            <td></td> \n" +
    "                        </tr> \n" +
    "                    </table> \n" +
    "                </div> \n" +
    "            </div>\n" +
    "                <div class=\"adM\">\n" +
    "                    <div style=\"background-color:#fff;padding:5px 20px;color:#000;border-radius:0px 0px 2px 2px\">\n" +
    "                        <div style=\"padding:35px 15px\">\n" +
    "                            <p style=\"margin:0;font-size:16px\">\n" +
    "                                Đơn hàng <span style=\"font-weight: 600; font-size: 20px;\">#" + model.Code + "</span> đã thanh toán thành công nhưng đã <span style=\"font-weight: 600; font-size: 20px; color: red;\">bị hủy</span> vì "+reason+". Vui lòng hoàn tiền cho khách hàng.\n" +
    "                            </p>\n" +
    "                            <br>\n" +
    "                            <p style=\"margin:0;font-size:20px; font-weight: 600;\">THÔNG TIN KHÁCH HÀNG:</p>\n" +
    "                            <ul style=\"margin-bottom: 0px;\">\n" +
    "                                <li><div style=\"padding: 10px 0;\">Username: <span>" + user.UserName + "</span></div></li>\n" +
    "                                <li><div style=\"padding: 10px 0;\">Họ và tên: <span>" + user.Fullname + "</span></div></li>\n" +
    "                                <li><div style=\"padding: 10px 0;\">Email: <span>" + user.Email + "</span></div></li>\n" +
    "                                <li><div style=\"padding: 10px 0;\">SĐT Đặt Hàng: <span>" + order.PhoneNumber + "</span></div></li>\n" +
    "                                <li><div style=\"padding: 10px 0;\">SĐT Người Dùng: <span>" + user.PhoneNumber + "</span></div></li>\n" +
    "                                <li><div style=\"padding: 10px 0;\">Tổng Tiền Hoàn: <span>" + order.TotalPrice + "</span></div></li>\n" +
    "                            </ul>\n" +
    "                        </div>\n" +
    "                    </div>\n" +
    "                </div>\n" +
    "            </div>\n" +
    "        </div>";
        }
    }
}
