﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace DXApplication1.Models
{
    class NguoiDungSql : DataLayer.DataAccess
    {

        SqlInfoMessageEventHandler showResultFromSql = (sender, e) =>
        {
            if(int.Parse(e.Message) == 1)
            {
                DialogResult result = MessageBox.Show("Thêm tài khoản thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        };

        public bool UpdatePass(NguoiDung user, string new_pass)
        {
            SqlCommand command = new SqlCommand("UPDATE_PASS", Connection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                command.Parameters.Add(new SqlParameter("@MA", SqlDbType.VarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, user.MaDangNhapNguoiDung));
                command.Parameters.Add(new SqlParameter("@PASS", SqlDbType.VarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, new_pass));
                Connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Connection.Close();
                command.Dispose();
                throw new Exception("User::UpdatePass::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                command.Dispose();
            }
        }

        public List<NguoiDung> SelectAll()
        {
            SqlCommand command = new SqlCommand("SELECT_ALL", Connection);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                Connection.Open();
                IDataReader data = command.ExecuteReader();
                return PopulateObjectFromReader(data);
            }
            catch (Exception ex)
            {
                Connection.Close();
                command.Dispose();
                throw new Exception("user::SelectAll::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                command.Dispose();
            }
        }

        // Đăng kí tài khoản

        public bool Register(NguoiDung user)
        {
            SqlCommand cmd = new SqlCommand("ThemTaiKhoan", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                
                cmd.Parameters.Add(new SqlParameter("@maDangNhapNguoiDung", SqlDbType.VarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, user.MaDangNhapNguoiDung));
                cmd.Parameters.Add(new SqlParameter("@matKhau", SqlDbType.VarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, user.MatKhau));
                cmd.Parameters.Add(new SqlParameter("@soDienThoai", SqlDbType.VarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, user.ThongTinNguoiDung.SoDienThoai));
                cmd.Parameters.Add(new SqlParameter("@hoTen", SqlDbType.VarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, user.ThongTinNguoiDung.HoTen));
                cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, user.ThongTinNguoiDung.Email));
                cmd.Parameters.Add(new SqlParameter("@diaChi", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, user.ThongTinNguoiDung.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@ngaySinh", SqlDbType.Date, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, user.ThongTinNguoiDung.NgaySinh.Date));
                
                Connection.Open();
                Connection.InfoMessage += showResultFromSql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra");
                return false;
            }
            finally
            {
                Connection.InfoMessage -= showResultFromSql;
                Connection.Close();
                cmd.Dispose();
            }
        }


        //


        internal void PopulatePlayerFromReader(NguoiDung user, IDataReader data)
        {
            user.MaDangNhapNguoiDung = data.GetString(data.GetOrdinal(NguoiDung.UserFields.MaDangNhapNguoiDung.ToString()));

            if (!data.IsDBNull(data.GetOrdinal(NguoiDung.UserFields.MatKhau.ToString())))
            {
                user.MatKhau = data.GetString(data.GetOrdinal(NguoiDung.UserFields.MatKhau.ToString()));
            }
        }


        internal List<NguoiDung> PopulateObjectFromReader(IDataReader data)
        {
            List<NguoiDung> list = new List<NguoiDung>();
            while (data.Read())
            {
                NguoiDung user = new NguoiDung();
                PopulatePlayerFromReader(user, data);
                list.Add(user);
            }
            return list;
        }

    }
}
