use QuanLySieuThi


/* Quyen */
insert into Quyens 
values ('796f8cd2-9c6f-4f35-8206-ba106a318abb','Admin','11/12/2018','false')
insert into Quyens 
values ('121fb82e-4e57-4fbe-83ce-6990d89bfcd7','User_Kho','11/12/2018','false')
insert into Quyens 
values ('442d15aa-8230-489e-bd1a-b5e6a28aac4e','User_BanHang','11/12/2018','false')
insert into Quyens 
values ('47439c65-647e-4966-8978-bc06d7b71602','User_ThongKe','11/12/2018','false')

go

/* TaiKhoan */
insert into TaiKhoans
values ('252b6af1-b666-424a-ac45-8bc43c811bfa','userkho','827ccb0eea8a706c4c34a16891f84e7b','121fb82e-4e57-4fbe-83ce-6990d89bfcd7','12/10/2018','false') /* 12345*/
insert into TaiKhoans
values ('6391127d-6043-497f-84e5-f87d86f1efbd','userbanhang','01cfcd4f6b8770febfb40cb906715822','442d15aa-8230-489e-bd1a-b5e6a28aac4e','07/06/2018','false') /* 54321 */
insert into TaiKhoans
values ('62e11a17-4210-4182-875e-4993f1a21c98','admin','21232f297a57a5a743894a0e4a801fc3','796f8cd2-9c6f-4f35-8206-ba106a318abb','11/10/2017','false') /* admin */
insert into TaiKhoans
values ('e7f969ea-ff2e-4b1d-b060-050dd401a9b0','userthongke','827ccb0eea8a706c4c34a16891f84e7b','47439c65-647e-4966-8978-bc06d7b71602','11/10/2017','false') /*12345*/

go

/* SanPham */
insert into  SanPhams 
values ('e99c1092-9c0f-4f17-982e-89f751c9ad47',N'Thịt heo',N'Thịt heo Đồng Tháp 1kg','/Image/images.jpg','10/04/2015','false')
insert into  SanPhams 
values ('18de371f-d8e1-4e26-be3a-d908a72ddcd8',N'Thịt gà đông lạnh',N'Thịt bò Đông lạnh ngon bổ dưỡng','/Image/images.jpg','10/05/2015','false')
insert into  SanPhams 
values ('ff784f1a-688e-403f-b727-bc64aa795ccf',N'Sữa chua Goku',N'Sữa chua được làm từ thịt heo','/Image/images.jpg','09/06/2015','false')
insert into  SanPhams 
values ('70009c73-db3f-45a8-bc44-d6374c531ddc',N'Cà chua',N'600g Cà chua Đà lạt','/Image/images.jpg','12/06/2015','false')
insert into  SanPhams 
values ('f2e30434-4b22-431c-936c-bd13b4d69890',N'Táo xanh',N'Táo xanh miền Trung màu mỡ','/Image/images.jpg','01/07/2015','false')
insert into  SanPhams 
values ('77758b08-d93a-438e-8ee7-64d917c68dff',N'Sửa ông thọ',N'4 hộp sữa ông thọ','/Image/images.jpg','09/08/2015','false')
insert into  SanPhams 
values ('4f16268f-ccc0-4383-a59a-55e17760610d',N'Sữa ông Tài',N'Sữa ông tài thơm ngon','/Image/images.jpg','11/09/2015','false')
insert into  SanPhams 
values ('3b51f846-7c53-4ad3-9bfd-9935f51c4070',N'Sữa vinamilk',N'Vinamilk','/Image/images.jpg','11/10/2015','false')
insert into  SanPhams 
values ('bae3c0f1-5c08-4eef-8dec-443b57195d62',N'Kem đánh răng',N'Kem đánh răng hiệu con gà trống','/Image/images.jpg','07/06/2016','false')
insert into  SanPhams 
values ('69a0e719-232a-4756-ac57-66b9b920b483',N'Nước rửa chén Sunlai',N'Nước rửa chén sunlai rửa siêu sạch','/Image/images.jpg','11/06/2016','false')
insert into  SanPhams 
values ('784a6243-c445-460a-93eb-ad4b020e5d68',N'Bình giữ nhiệt 200ml',N'Giữ được nóng, lạnh ở nhiệt độ 0-10 và 80-100 độ','/Image/images.jpg','12/12/2016','false')

go

/* NhaCungCap */
insert into NhaCungCaps 
values ('60c1d22e-ce62-4cd2-9d31-c1cc9da2b5a9',N'Công ty Vina',N'14/2 chung cư Hùng Vương, P9, Q5,TP. HCM','11/06/2015','false')
insert into NhaCungCaps 
values ('28094f20-ebba-4292-ac75-df252f8838fe',N'Công ty Vạn Thành',N'100 Nguyễn Tri Phương, P3, Q5,TP. HCM','12/06/2015','false')
insert into NhaCungCaps 
values ('44aad5aa-acef-41e4-9684-c97442f01e12',N'Hứa Trần Văn',N'28 Trần Duy Dương, P7, Q11, TP.HCM','07/06/2015','false')
insert into NhaCungCaps 
values ('b6a544a5-0917-4d3b-a975-c1104953f6ed',N'Công ty Vua',N'66 Phạm Văn Đồng, P8, Bình Dương','03/01/2015','false')
insert into NhaCungCaps 
values ('b3ba0b28-c711-4291-9398-2daece34152b',N'Tài Lộc',N'116 Nguyễn Huệ, P1, TPCL, Đồng Tháp','11/11/2015','false')
insert into NhaCungCaps 
values ('28b56d07-3827-48d4-b635-f0bc0f14271a',N'Công ty Goku',N'489 Phù Đổng Thiên Vương, P11, Q5, TP.HCM','12/05/2016','false')

go

/* SanPham_NCC */
insert into SanPham_NCC 
values ('ee75cdce-138c-4220-bc3c-849105e10e7e','e99c1092-9c0f-4f17-982e-89f751c9ad47','28094f20-ebba-4292-ac75-df252f8838fe','06/06/2016','false')
insert into SanPham_NCC 
values ('749e7f2f-c0d7-4fed-90ed-b574c6bca126','e99c1092-9c0f-4f17-982e-89f751c9ad47','44aad5aa-acef-41e4-9684-c97442f01e12','06/07/2016','false')
insert into SanPham_NCC 
values ('5e69476f-8da2-4eae-94ce-faf3558ffee8','18de371f-d8e1-4e26-be3a-d908a72ddcd8','28094f20-ebba-4292-ac75-df252f8838fe','06/07/2016','false')
insert into SanPham_NCC 
values ('daf0389d-7ebd-4101-b00a-9c9997877783','18de371f-d8e1-4e26-be3a-d908a72ddcd8','28b56d07-3827-48d4-b635-f0bc0f14271a','06/10/2016','false')
insert into SanPham_NCC 
values ('84fd2391-e083-437c-beb2-083ffbe9b08c','ff784f1a-688e-403f-b727-bc64aa795ccf','44aad5aa-acef-41e4-9684-c97442f01e12','11/12/2016','false')
insert into SanPham_NCC 
values ('a5f0cfa6-7fd8-430f-a193-71dab6ae8c7d','70009c73-db3f-45a8-bc44-d6374c531ddc','28b56d07-3827-48d4-b635-f0bc0f14271a','04/07/2017','false')
insert into SanPham_NCC 
values ('be6eacce-5041-44a1-933a-5189c54b8941','f2e30434-4b22-431c-936c-bd13b4d69890','b3ba0b28-c711-4291-9398-2daece34152b','04/07/2017','false')
insert into SanPham_NCC 
values ('5615da52-0733-4e3c-bf1d-e09361ef083d','77758b08-d93a-438e-8ee7-64d917c68dff','60c1d22e-ce62-4cd2-9d31-c1cc9da2b5a9','10/01/2018','false')
insert into SanPham_NCC 
values ('83057705-2412-4e45-b0c1-e30f434f0a7d','4f16268f-ccc0-4383-a59a-55e17760610d','60c1d22e-ce62-4cd2-9d31-c1cc9da2b5a9','11/02/2018','false')
insert into SanPham_NCC 
values ('5c76867e-1162-4474-99eb-64f2304af382','3b51f846-7c53-4ad3-9bfd-9935f51c4070','60c1d22e-ce62-4cd2-9d31-c1cc9da2b5a9','06/02/2018','false')
insert into SanPham_NCC 
values ('199c4832-9d83-4c7a-8275-b7cb0489ff6e','bae3c0f1-5c08-4eef-8dec-443b57195d62','28b56d07-3827-48d4-b635-f0bc0f14271a','12/09/2018','false')
insert into SanPham_NCC 
values ('b9e3b45c-ce42-4d89-9fcb-02f84d1a0eb8','69a0e719-232a-4756-ac57-66b9b920b483','b3ba0b28-c711-4291-9398-2daece34152b','04/05/2019','false')
insert into SanPham_NCC 
values ('72bdfef8-ab6b-49bd-8767-00d0787d5ad2','784a6243-c445-460a-93eb-ad4b020e5d68','b6a544a5-0917-4d3b-a975-c1104953f6ed','05/05/2019','false')

go

/* NhanVien */
insert into NhanViens 
values ('8de12258-c294-4a4f-b0ae-ff1c569f02b4',N'Nguyễn Văn Thành','62e11a17-4210-4182-875e-4993f1a21c98','11/06/2017','false')
insert into NhanViens 
values ('db1d1aa6-d93c-4260-bc51-88cf81055dea',N'Hứa Hà Sơn','252b6af1-b666-424a-ac45-8bc43c811bfa','12/03/2017','false')
insert into NhanViens 
values ('10ade52e-a186-480a-a6f1-af5d34f88d34',N'Trần Minh Phúc','6391127d-6043-497f-84e5-f87d86f1efbd','06/03/2017','false')
insert into NhanViens 
values ('06d77d13-051c-46ca-9478-1ea06bcea5a6',N'Lẻ Hữu Tài','e7f969ea-ff2e-4b1d-b060-050dd401a9b0','06/03/2017','false')

go

/* SLTon */
insert into SLTons 
values ('d9a17757-9a9b-4f1d-8602-ef705ca555a4','12','f2e30434-4b22-431c-936c-bd13b4d69890','b3ba0b28-c711-4291-9398-2daece34152b','11/04/2018','false')
insert into SLTons 
values ('ab06b0c7-5a0b-4dde-aa4b-a884e9871737','18','784a6243-c445-460a-93eb-ad4b020e5d68','b6a544a5-0917-4d3b-a975-c1104953f6ed','12/04/2018','false')
insert into SLTons 
values ('b7a1551a-8340-4a2a-a9bd-c8cf397cd404','14','bae3c0f1-5c08-4eef-8dec-443b57195d62','28b56d07-3827-48d4-b635-f0bc0f14271a','01/05/2018','false')
insert into SLTons 
values ('b95c2520-10e7-421e-96d3-6064b2103c78','17','e99c1092-9c0f-4f17-982e-89f751c9ad47','44aad5aa-acef-41e4-9684-c97442f01e12','12/05/2018','false')
insert into SLTons 
values ('61bc4d31-df06-4452-a10b-f9fb337348a5','10','18de371f-d8e1-4e26-be3a-d908a72ddcd8','28094f20-ebba-4292-ac75-df252f8838fe','07/01/2019','false')
insert into SLTons 
values ('0d605d01-1d42-4be5-b066-22a7131e2c01','15','77758b08-d93a-438e-8ee7-64d917c68dff','60c1d22e-ce62-4cd2-9d31-c1cc9da2b5a9','07/01/2019','false')
insert into SLTons 
values ('52e32c0d-cd0c-4efb-a434-1e7f2dec6eaf','122','f2e30434-4b22-431c-936c-bd13b4d69890','b3ba0b28-c711-4291-9398-2daece34152b','07/02/2019','false')
insert into SLTons 
values ('e3252d33-93ec-4b54-b295-563dc4cddfb1','09','3b51f846-7c53-4ad3-9bfd-9935f51c4070','60c1d22e-ce62-4cd2-9d31-c1cc9da2b5a9','11/02/2019','false')
insert into SLTons 
values ('0d6f93c8-c65d-4d23-83b9-ff124f7fc09a','15','ff784f1a-688e-403f-b727-bc64aa795ccf','ff784f1a-688e-403f-b727-bc64aa795ccf','05/02/2019','false')
insert into SLTons 
values ('d6fc0f72-315d-47fe-b9f7-19919b41e3df','24','18de371f-d8e1-4e26-be3a-d908a72ddcd8','28b56d07-3827-48d4-b635-f0bc0f14271a','04/05/2019','false')
insert into SLTons 
values ('dffa423f-ce05-4ec8-92bb-cb0e29b75f95','16','4f16268f-ccc0-4383-a59a-55e17760610d','60c1d22e-ce62-4cd2-9d31-c1cc9da2b5a9','08/07/2019','false')
insert into SLTons 
values ('a61389fa-0257-441c-b65d-e8f182442642','10','784a6243-c445-460a-93eb-ad4b020e5d68','b6a544a5-0917-4d3b-a975-c1104953f6ed','12/08/2019','false')
insert into SLTons 
values ('e3436b9a-fb6f-4d1a-ba71-b3e8d5439ba3','115','f2e30434-4b22-431c-936c-bd13b4d69890','b3ba0b28-c711-4291-9398-2daece34152b','11/09/2019','false')
insert into SLTons 
values ('fd0f9cb4-ff18-4ab9-bd6d-bfcce795f663','12','ff784f1a-688e-403f-b727-bc64aa795ccf','ff784f1a-688e-403f-b727-bc64aa795ccf','11/09/2019','false')
insert into SLTons 
values ('2da7af61-dcc8-4161-83d6-cd6a297f761c','19','18de371f-d8e1-4e26-be3a-d908a72ddcd8','28b56d07-3827-48d4-b635-f0bc0f14271a','12/09/2019','false')
insert into SLTons 
values ('aee6c24e-b40a-4c93-b4d2-8ba00a7c53ed','12','4f16268f-ccc0-4383-a59a-55e17760610d','60c1d22e-ce62-4cd2-9d31-c1cc9da2b5a9','05/10/2019','false')
insert into SLTons 
values ('94427639-ed23-4fc1-9169-edfcb5d2b947','14','e99c1092-9c0f-4f17-982e-89f751c9ad47','28094f20-ebba-4292-ac75-df252f8838fe','07/10/2019','false')
insert into SLTons
values ('b978106d-b738-4964-b491-5e2c879b1f5b','6','77758b08-d93a-438e-8ee7-64d917c68dff','60c1d22e-ce62-4cd2-9d31-c1cc9da2b5a9','11/11/2019','false')
insert into SLTons 
values ('19a50c56-2f4a-41fc-ba28-82f86752b1a5','15','18de371f-d8e1-4e26-be3a-d908a72ddcd8','28094f20-ebba-4292-ac75-df252f8838fe','10/12/2019','false')

go

--PhieuNhap--
insert into PhieuNhaps
values ('92420e7d-0631-4ba7-bbd2-6c56e6d1077a','11/04/2018','14400','28094f20-ebba-4292-ac75-df252f8838fe','11/04/2018','false');
insert into PhieuNhaps
values ('551d2e9b-4a18-49bd-a4d9-3ec36ac55904','12/04/2018','18000','60c1d22e-ce62-4cd2-9d31-c1cc9da2b5a9','12/04/2018','false');
insert into PhieuNhaps
values ('7f1b9dbf-d38f-4e13-b8d7-def465cf0cd7','01/05/2018','15400','b6a544a5-0917-4d3b-a975-c1104953f6ed','01/05/2018','false');
insert into PhieuNhaps
values ('e46cb9e6-30cc-46b3-b785-3a29a48c0259','12/05/2018','17850','28094f20-ebba-4292-ac75-df252f8838fe','12/05/2018','false');
insert into PhieuNhaps
values ('7d5e6af4-e0a5-4b3c-99a8-8fa53132e054','07/01/2019','9000','28b56d07-3827-48d4-b635-f0bc0f14271a','07/01/2019','false');
insert into PhieuNhaps
values ('9730f392-93d2-48bc-b8c5-2d6e747f2de0','07/01/2019','11250','b6a544a5-0917-4d3b-a975-c1104953f6ed','07/01/2019','false');
insert into PhieuNhaps
values ('65786f9f-ee51-46e5-bc58-33d7731245a0','07/02/2019','22000','28094f20-ebba-4292-ac75-df252f8838fe','07/02/2019','false');
insert into PhieuNhaps
values ('8d9c7d65-9ae5-425a-b7c9-fdec075acf72','11/02/2019','11250','60c1d22e-ce62-4cd2-9d31-c1cc9da2b5a9','11/02/2019','false');
insert into PhieuNhaps
values ('237c89dd-330c-472a-90f9-dc6eeabba401','05/02/2019','17250','60c1d22e-ce62-4cd2-9d31-c1cc9da2b5a9','05/02/2019','false');
insert into PhieuNhaps
values ('d1412b30-6284-41dc-951d-d0ad9b8338f2','04/05/2019','22400','44aad5aa-acef-41e4-9684-c97442f01e12','04/05/2019','false');
insert into PhieuNhaps
values ('5a566732-91fe-47d4-9e24-47c01a13b2f2','08/07/2019','28800','b3ba0b28-c711-4291-9398-2daece34152b','08/07/2019','false');

go

--CTPhieuNhap--
insert into CTPhieuNhaps(MaPN,MaSP,SLNhap,createdDate,isDeleted)
values ('1','5','12','11/04/2018','false');
insert into CTPhieuNhaps(MaPN,MaSP,SLNhap,createdDate,isDeleted)
values ('2','11','18','12/04/2018','false');
insert into CTPhieuNhaps(MaPN,MaSP,SLNhap,createdDate,isDeleted)
values ('3','9','14','01/05/2018','false');
insert into CTPhieuNhaps(MaPN,MaSP,SLNhap,createdDate,isDeleted)
values ('4','1','17','12/05/2018','false');
insert into CTPhieuNhaps(MaPN,MaSP,SLNhap,createdDate,isDeleted)
values ('5','2','10','07/01/2019','false');
insert into CTPhieuNhaps(MaPN,MaSP,SLNhap,createdDate,isDeleted)
values ('6','6','15','07/01/2019','false');
insert into CTPhieuNhaps(MaPN,MaSP,SLNhap,createdDate,isDeleted)
values ('7','5','110','07/02/2019','false');
insert into CTPhieuNhaps(MaPN,MaSP,SLNhap,createdDate,isDeleted)
values ('8','8','9','11/02/2019','false');
insert into CTPhieuNhaps(MaPN,MaSP,SLNhap,createdDate,isDeleted)
values ('9','3','15','05/02/2019','false');
insert into CTPhieuNhaps(MaPN,MaSP,SLNhap,createdDate,isDeleted)
values ('10','2','14','04/05/2019','false');
insert into CTPhieuNhaps(MaPN,MaSP,SLNhap,createdDate,isDeleted)
values ('11','7','16','08/07/2019','false');

go

--DonGiaNhap--
insert into DonGiaNhaps(MaNCC,NgayApDung,createdDate,isDeleted)
values ('1','10/02/2017','03/01/2017','false');
insert into DonGiaNhaps(MaNCC,NgayApDung,createdDate,isDeleted)
values ('4','08/04/2017','12/01/2017','false');
insert into DonGiaNhaps(MaNCC,NgayApDung,createdDate,isDeleted)
values ('6','02/04/2017','01/04/2017','false');
insert into DonGiaNhaps(MaNCC,NgayApDung,createdDate,isDeleted)
values ('1','12/04/2017','12/04/2017','false');
insert into DonGiaNhaps(MaNCC,NgayApDung,createdDate,isDeleted)
values ('2','07/02/2018','08/01/2018','false');
insert into DonGiaNhaps(MaNCC,NgayApDung,createdDate,isDeleted)
values ('6','07/02/2018','12/01/2018','false');
insert into DonGiaNhaps(MaNCC,NgayApDung,createdDate,isDeleted)
values ('1','07/03/2018','12/02/2018','false');
insert into DonGiaNhaps(MaNCC,NgayApDung,createdDate,isDeleted)
values ('4','11/03/2018','12/02/2018','false');
insert into DonGiaNhaps(MaNCC,NgayApDung,createdDate,isDeleted)
values ('4','05/04/2018','08/02/2018','false');
insert into DonGiaNhaps(MaNCC,NgayApDung,createdDate,isDeleted)
values ('3','04/05/2018','08/03/2018','false');
insert into DonGiaNhaps(MaNCC,NgayApDung,createdDate,isDeleted)
values ('5','08/06/2018','08/05/2018','false');

go

--CTDonGiaNhap--
insert into CTDonGiaNhaps(MaPhieuGiaNhap,MaSP,GiaNhap,createdDate,isDeleted)
values ('1','5','1200','03/01/2017','false');
insert into CTDonGiaNhaps(MaPhieuGiaNhap,MaSP,GiaNhap,createdDate,isDeleted)
values ('2','11','1000','12/01/2017','false');
insert into CTDonGiaNhaps(MaPhieuGiaNhap,MaSP,GiaNhap,createdDate,isDeleted)
values ('3','9','1100','01/04/2017','false');
insert into CTDonGiaNhaps(MaPhieuGiaNhap,MaSP,GiaNhap,createdDate,isDeleted)
values ('4','1','1050','12/04/2017','false');
insert into CTDonGiaNhaps(MaPhieuGiaNhap,MaSP,GiaNhap,createdDate,isDeleted)
values ('5','2','900','08/01/2018','false');
insert into CTDonGiaNhaps(MaPhieuGiaNhap,MaSP,GiaNhap,createdDate,isDeleted)
values ('6','6','750','12/01/2018','false');
insert into CTDonGiaNhaps(MaPhieuGiaNhap,MaSP,GiaNhap,createdDate,isDeleted)
values ('7','5','200','12/02/2018','false');
insert into CTDonGiaNhaps(MaPhieuGiaNhap,MaSP,GiaNhap,createdDate,isDeleted)
values ('8','8','1250','12/02/2018','false');
insert into CTDonGiaNhaps(MaPhieuGiaNhap,MaSP,GiaNhap,createdDate,isDeleted)
values ('9','3','1150','08/03/2018','false');
insert into CTDonGiaNhaps(MaPhieuGiaNhap,MaSP,GiaNhap,createdDate,isDeleted)
values ('10','2','1600','08/03/2018','false');
insert into CTDonGiaNhaps(MaPhieuGiaNhap,MaSP,GiaNhap,createdDate,isDeleted)
values ('11','7','1800','08/05/2018','false');

go

--DonGiaBan--
insert into DonGiaBans
values ('913f3b2d-834f-4410-b678-90279e7bf06a','12/04/2017','12/01/2017','false');
insert into DonGiaBans
values ('0efdd7ae-de9f-4ab8-8d40-45670587b91b','12/04/2017','12/01/2017','false');
insert into DonGiaBans
values ('197b2d3a-0029-4f70-bd13-932dc7a7517c','12/04/2017','11/04/2017','false');
insert into DonGiaBans
values ('8b5e99ca-eb7b-46b5-a8c2-82a5cbac70ef','12/04/2017','12/04/2017','false');
insert into DonGiaBans
values ('c3ee57df-bd23-433b-b26b-83ce4dda81eb','12/04/2018','11/04/2018','false');
insert into DonGiaBans
values ('277b582e-4759-4cbf-ac2e-5d82ab6aa94a','12/04/2018','11/04/2018','false');
insert into DonGiaBans
values ('55f49e5e-c57b-4892-8896-6ec189c08c69','12/04/2018','11/04/2018','false');
insert into DonGiaBans
values ('c6a4dd17-557c-4856-99af-91fa5ca1950f','12/04/2018','11/04/2018','false');
insert into DonGiaBans
values ('34c22c9d-0bce-4c81-8a1d-83f818edd1c8','12/04/2018','11/04/2018','false');
insert into DonGiaBans
values ('5a57babb-4ee5-4fa0-9314-9664aa0f5a3b','12/04/2018','11/04/2018','false');
insert into DonGiaBans
values ('6f776073-2083-4ae8-b3e9-d8fb7ac296dc','12/04/2018','11/04/2018','false');

go

--CTDonGiaBan--
insert into CTDonGiaBans
values ('f01c1095-0e25-4fbd-9a12-6669dedc149f','0efdd7ae-de9f-4ab8-8d40-45670587b91b','70009c73-db3f-45a8-bc44-d6374c531ddc','1500','03/01/2017','false');
insert into CTDonGiaBans
values ('1e4a344b-e323-4cd6-9088-07443381e1f9','197b2d3a-0029-4f70-bd13-932dc7a7517c','ff784f1a-688e-403f-b727-bc64aa795ccf','1200','12/01/2017','false');
insert into CTDonGiaBans
values ('bcb63c55-fc27-4f4e-acc7-5f7505892e1f','277b582e-4759-4cbf-ac2e-5d82ab6aa94a','e99c1092-9c0f-4f17-982e-89f751c9ad47','1300','01/04/2017','false');
insert into CTDonGiaBans
values ('da8e8746-ecf9-4fc8-8ac9-8dbbdf8c37ff','34c22c9d-0bce-4c81-8a1d-83f818edd1c8','18de371f-d8e1-4e26-be3a-d908a72ddcd8','1150','12/04/2017','false');
insert into CTDonGiaBans
values ('b5806801-c6ce-4461-b79e-3a6dd975c8c0','34c22c9d-0bce-4c81-8a1d-83f818edd1c8','3b51f846-7c53-4ad3-9bfd-9935f51c4070','1100','08/01/2018','false');
insert into CTDonGiaBans
values ('a98f0afd-b479-4965-ae8b-b857330c67bb','5a57babb-4ee5-4fa0-9314-9664aa0f5a3b','77758b08-d93a-438e-8ee7-64d917c68dff','1000','12/01/2018','false');
insert into CTDonGiaBans
values ('f690b6c9-966b-4a6b-8043-a3d13e5622fa','6f776073-2083-4ae8-b3e9-d8fb7ac296dc','70009c73-db3f-45a8-bc44-d6374c531ddc','500','12/02/2018','false');
insert into CTDonGiaBans
values ('5a2ffac0-4470-4df6-a863-9dc82b0cc47d','8b5e99ca-eb7b-46b5-a8c2-82a5cbac70ef','bae3c0f1-5c08-4eef-8dec-443b57195d62','1450','12/02/2018','false');
insert into CTDonGiaBans
values ('7b0451e6-381e-41f5-8698-843be784bc4d','913f3b2d-834f-4410-b678-90279e7bf06a','4f16268f-ccc0-4383-a59a-55e17760610d','1550','08/03/2018','false');
insert into CTDonGiaBans
values ('d1b8bf5a-c1e1-4bf3-babe-287a5b77c7ae','c3ee57df-bd23-433b-b26b-83ce4dda81eb','3b51f846-7c53-4ad3-9bfd-9935f51c4070','1900','08/03/2018','false');
insert into CTDonGiaBans
values ('f3246be9-f69a-44d6-83d0-4a0743074e26','c6a4dd17-557c-4856-99af-91fa5ca1950f','784a6243-c445-460a-93eb-ad4b020e5d68','2000','08/05/2018','false');
insert into CTDonGiaBans
values ('2e4a344b-e323-4cd6-9088-07443381e1f9','197b2d3a-0029-4f70-bd13-932dc7a7517c','ff784f1a-688e-403f-b727-bc64aa795ccf','200','12/02/2017','false');

go

--HoaDon--
insert into HoaDons
values ('cb7a5b29-d486-433f-8b23-eaaf4607bc41','12/08/2019','9600','12/08/2019','false');
insert into HoaDons
values ('800f8b24-edb8-4641-90d0-33cd55233da3','11/09/2019','3500','11/09/2019','false');
insert into HoaDons
values ('88a6e1a3-d4fd-46e1-8a68-a79712910b67','11/09/2019','4650','11/09/2019','false');
insert into HoaDons
values ('10fad06a-912b-4122-be3d-0753a0ab46ee','12/09/2019','24700','12/09/2019','false');
insert into HoaDons
values ('e7800011-2bf3-496d-b63d-59b285c69357','05/10/2019','8000','05/10/2019','false');
insert into HoaDons
values ('7c4dd9f6-1ad2-4d00-9757-4e3c5a12b784','07/10/2019','3450','07/10/2019','false');
insert into HoaDons
values ('40b9bf52-8442-4c26-933a-285961a3caf7','11/11/2019','5200','11/11/2019','false');
insert into HoaDons
values ('5b8e5f6f-1f84-422f-911e-cdb386a19f06','10/12/2019','7600','10/12/2019','false');

go

--CTHoaDon--
insert into CTHoaDons
values ('43829400-5d28-452a-9078-73d16f365be4','10fad06a-912b-4122-be3d-0753a0ab46ee','ff784f1a-688e-403f-b727-bc64aa795ccf','60c1d22e-ce62-4cd2-9d31-c1cc9da2b5a9','8','12/08/2019','false');
insert into CTHoaDons
values ('53829400-5d28-452a-9078-73d16f365be4','10fad06a-912b-4122-be3d-0753a0ab46ee','3b51f846-7c53-4ad3-9bfd-9935f51c4070','60c1d22e-ce62-4cd2-9d31-c1cc9da2b5a9','8','12/08/2019','false');
insert into CTHoaDons
values ('ea1f13f4-7875-44e7-b94a-687ee054b193','40b9bf52-8442-4c26-933a-285961a3caf7','70009c73-db3f-45a8-bc44-d6374c531ddc','28094f20-ebba-4292-ac75-df252f8838fe','7','11/09/2019','false');
insert into CTHoaDons
values ('14eff062-286c-481a-a3d2-8e869275059b','5b8e5f6f-1f84-422f-911e-cdb386a19f06','4f16268f-ccc0-4383-a59a-55e17760610d','60c1d22e-ce62-4cd2-9d31-c1cc9da2b5a9','3','11/09/2019','false');
insert into CTHoaDons
values ('e46203b5-a285-455b-80fa-1f05470950ff','7c4dd9f6-1ad2-4d00-9757-4e3c5a12b784','3b51f846-7c53-4ad3-9bfd-9935f51c4070','28b56d07-3827-48d4-b635-f0bc0f14271a','5','12/09/2019','false');
insert into CTHoaDons
values ('e2472b8b-8663-4b20-8446-4ada869835bf','800f8b24-edb8-4641-90d0-33cd55233da3','784a6243-c445-460a-93eb-ad4b020e5d68','b3ba0b28-c711-4291-9398-2daece34152b','4','05/10/2019','false');
insert into CTHoaDons
values ('af0380c5-d2bc-4cec-a161-93bf155d7e69','88a6e1a3-d4fd-46e1-8a68-a79712910b67','18de371f-d8e1-4e26-be3a-d908a72ddcd8','28094f20-ebba-4292-ac75-df252f8838fe','3','07/10/2019','false');
insert into CTHoaDons
values ('13066e8e-efdf-4afc-b733-eb08134c63ac','cb7a5b29-d486-433f-8b23-eaaf4607bc41','e99c1092-9c0f-4f17-982e-89f751c9ad47','b6a544a5-0917-4d3b-a975-c1104953f6ed','4','11/11/2019','false');
insert into CTHoaDons
values ('e55f0598-6f06-43a2-a0bc-2c851d19b954','e7800011-2bf3-496d-b63d-59b285c69357','3b51f846-7c53-4ad3-9bfd-9935f51c4070','28b56d07-3827-48d4-b635-f0bc0f14271a','4','10/12/2019','false');


select * from NhaCungCaps
select * from HoaDons hd where hd.NgayHD='12/09/2019'
select * from SanPhams
select * from CTHoaDons
select* from CTDonGiaBans ctdg
where MaSP='ff784f1a-688e-403f-b727-bc64aa795ccf'
order by createdDate desc

select * froM DonGiaBans
select * from SLTons




select * from SanPham_NCC

select MaSP,MaNCC,SoLuong,createdDate from SLTons where MaSP='18de371f-d8e1-4e26-be3a-d908a72ddcd8' 
group by MaSP,MaNCC,SoLuong,createdDate
order by createdDate desc



select * from DonGiaBans

select *, 
(select TOP 1 ctdg.GiaBan from CTDonGiaBans ctdg,DonGiaBans dg where cthd.MaSP=ctdg.MaSP and ctdg.MaDonGiaBan=dg.id and ctdg.isDeleted='false' and hd.NgayHD>=dg.NgayApDung order by ctdg.createdDate desc) 
from CTHoaDons cthd,HoaDons hd where cthd.MaHD = 'cb7a5b29-d486-433f-8b23-eaaf4607bc41' and cthd.MaHD=hd.id;
select * from CTDonGiaBans;

select * from SanPham_NCC order by MaSP

