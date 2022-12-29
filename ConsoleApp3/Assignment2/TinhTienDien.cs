using System;
namespace TT2203E.Assignment2;
public class TinhTienDien	
{
	public TinhTienDien()
	{
	}
	public int DinhMuc { get; set; }
	public int Soluong { get; set; }
	public int DonGia { get; set; }
	public int KWVuotDinhMuc { get; set; }
	public int DonGiaMoi { get; set; }
	public int ThanhTien { get; set; }
	public int KhachHangVN(int SoLuong, int DinhMuc,int DonGia,int DonGiaMoi)
	{
		if(Soluong < DinhMuc)
		{
			 ThanhTien = SoLuong * DonGia;
			Console.WriteLine(ThanhTien);
			return 0;
		}
		else
		{
			return ThanhTien = DonGia * DinhMuc + (SoLuong - DinhMuc) * DonGiaMoi;
		}
	}
	public int KhachHangNcNgoai(int SoLuong, int DonGia)
	{
		return ThanhTien = SoLuong * DonGia; 
	}

}
