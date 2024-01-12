﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class SanPham
    {
        private string _ten;
        private double _giamua;
        public SanPham() { }
        public SanPham(string ten, double giamua)
        {
            this._ten = ten;
            this._giamua = giamua;
        }
        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        public double GiaMua
        {
            get { return _giamua; }
            set
            {
                if (value >= 0)
                    _giamua = value;
            }
        }
        public virtual double TinhGiaBan()
        {
            return 0;
        }
        public virtual string InChiTiet()
        {
            return _ten;
        }
        public virtual void Nhap()
        {
            Console.Write("Cho biet ten san pham:");
            _ten = Console.ReadLine();
            Console.Write("Cho biet gia ban:");
            _giamua = double.Parse(Console.ReadLine());
        }
    }


    //Dinh nghia lop Socola
    class Socola : SanPham
    {
        private double _loinhuan;
        public Socola() : base() { }
        public Socola(string ten, double giamua) : base(ten, giamua)
        {
            _loinhuan = GiaMua * 0.2;
        }
        public override double TinhGiaBan()
        {
            return GiaMua + _loinhuan;
        }
        public override string InChiTiet()
        {
            return string.Format("Ten: {0} - Gia ban: {1: #,##0}", Ten, TinhGiaBan());
        }
        public override void Nhap()
        {
            base.Nhap();
            _loinhuan = GiaMua * 0.2;
        }
    }

    //Dinh nghia lop Nuocuong
    class NuocUong : SanPham

    {
        private double _loinhuan;
        private double _ChiPhiGiuLanh;


        public NuocUong() : base() { }
        public NuocUong(string ten, double giamua) : base(ten, giamua)
        {
            _loinhuan = GiaMua * 0.15;
            _ChiPhiGiuLanh = GiaMua * 0.1;
        }


        public override double TinhGiaBan()
        {
            return GiaMua + _loinhuan + _ChiPhiGiuLanh;
        }

        public override string InChiTiet()
        {
            return string.Format("Ten: {0} - Gia ban: {1: #,##0}", Ten, TinhGiaBan());
        }

        public override void Nhap()
        {
            base.Nhap();
            _loinhuan = GiaMua * 0.15;
            _ChiPhiGiuLanh = GiaMua * 0.1;
        }
    }

    class QuanLySanPham
    {
        private string _ten;
        private SanPham[] dssp;
        private int n;

        public QuanLySanPham()
        {
            _ten = "Cua hang ban le";
            dssp = new SanPham[100];
            n = 0;
        }
        public QuanLySanPham(int size)
        {
            _ten = "Cua hang ban le";
            dssp = new SanPham[size];
            n = 0;
        }
        public void Nhap()
        {
            int chon;
            SanPham sp;
            while (true)
            {
                Console.Write("Ban muon them san pham nao (1.Socola - 2.Nuoc uong): ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        sp = new Socola();
                        sp.Nhap();
                        dssp[n++] = sp;
                        break;
                    case 2:
                        sp = new NuocUong();
                        sp.Nhap();
                        dssp[n++] = sp;
                        break;
                }
                Console.Write("Ban co tiep tuc ?(0. Thoat):");
                chon = int.Parse(Console.ReadLine());
                if (chon == 0)
                    break;
            }

        }
        public void InDanhSachSP()
        {
            Console.WriteLine("*******Ten cua hang:" + _ten);
            Console.Write("*********Danh sach cac san pham*********");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dssp[i].InChiTiet());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            QuanLySanPham q1 = new QuanLySanPham();
            q1.Nhap();
            q1.InDanhSachSP();
            Console.ReadLine();
        }
    }
}



     