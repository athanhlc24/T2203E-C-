using System;

public class TinhTienDien	
{
	public TinhTienDien()
	{
	}
	public int DinhMuc { get; set; };
	public int Soluong { get; set; };
	public int DonGia { get; set; };
	public int KWVuotDinhMuc { get; set; }
	public int DonGiaMoi { get; set; }
	public int ThanhTien { get; set; }
	public int KhachHangVN()
	{
		if(Soluong < DinhMuc)
		{
			return ThanhTien = Soluong * DonGia;
		}
		else
		{
			return ThanhTien = DonGia * DinhMuc + (Soluong - DinhMuc) * DonGiaMoi;
		}
	}
	public int KhachHangNcNgoai()
	{
		return ThanhTien = Soluong * DonGia; 
	}

}
