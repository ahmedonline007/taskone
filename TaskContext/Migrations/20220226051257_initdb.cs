using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskContext.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblUsersPhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsersPhoneNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblSendMessage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSendMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblSendMessage_tblUsersPhoneNumbers_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUsersPhoneNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "tblUsersPhoneNumbers",
                columns: new[] { "Id", "AddedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "NameUser", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("2c1a629c-ef76-4708-a1f3-09a8123a0d32"), new DateTime(2022, 2, 26, 7, 12, 56, 694, DateTimeKind.Local).AddTicks(6677), null, null, null, "Ahmed1", "01009615946" },
                    { new Guid("6a1e288e-e943-419c-8c8e-7aa78638702f"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5711), null, null, null, "Alexander Hendrix", "(06494) 3685877" },
                    { new Guid("b38ff18b-6730-4be6-9d27-b446f8e04249"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5709), null, null, null, "Rebekah Mooney", "(0977) 85347403" },
                    { new Guid("8182ae0c-b6db-467c-8a3e-a3e739fad276"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5708), null, null, null, "Ocean Glenn", "(035533) 476735" },
                    { new Guid("a5883331-ce70-4805-8390-2892397f4141"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5706), null, null, null, "Tanisha Gutierrez", "(01137) 7162891" },
                    { new Guid("80917d82-69bb-426f-8ad6-6acc7f5f6d9d"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5702), null, null, null, "Cally Barr", "(0857) 53334108" },
                    { new Guid("bcce7be8-7143-412f-9577-2738c102c370"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5701), null, null, null, "Lana Hudson", "(095) 35767831" },
                    { new Guid("9c522a08-65c4-4e3e-b7d3-ae27853edc78"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5699), null, null, null, "Elijah Mueller", "(032476) 601138" },
                    { new Guid("e9bf2a46-86d4-446e-afae-e6efc1881f2e"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5697), null, null, null, "Madaline Vinson", "(035) 45331372" },
                    { new Guid("86c02456-6ca1-4484-8e9f-fd5bbca48e8a"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5695), null, null, null, "Colorado Dotson", "(058) 41455821" },
                    { new Guid("f63fcfdf-5ff1-4559-a2a6-5e00be64e24e"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5693), null, null, null, "Lamar Robles", "(00593) 5308822" },
                    { new Guid("824cf18c-e2d0-4ba0-a11d-6fa54b29c034"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5692), null, null, null, "Alexander Hendrix", "(06494) 3685877" },
                    { new Guid("660f218d-9a29-454d-a99b-64eeabceeda1"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5690), null, null, null, "Rebekah Mooney", "(0977) 85347403" },
                    { new Guid("d6c9d362-f827-45fb-bcf5-ae4f6b150029"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5686), null, null, null, "Ocean Glenn", "(035533) 476735" },
                    { new Guid("e6eb31e0-d730-495a-9657-b8249fd8ba24"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5685), null, null, null, "Tanisha Gutierrez", "(01137) 7162891" },
                    { new Guid("f837fcbf-09de-443e-b1de-7c7e650d725c"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5683), null, null, null, "Cally Barr", "(0857) 53334108" },
                    { new Guid("91322557-92e8-40dd-9ef4-89431ad38d5b"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5682), null, null, null, "Lana Hudson", "(095) 35767831" },
                    { new Guid("6af6564b-2587-45ca-b9f3-2cf524292403"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5680), null, null, null, "Elijah Mueller", "(032476) 601138" },
                    { new Guid("db455aff-b06f-48ec-bf2b-f806e8619b0e"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5678), null, null, null, "Madaline Vinson", "(035) 45331372" },
                    { new Guid("4cb82800-3e54-4e21-b209-68ad39f9c6cf"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5677), null, null, null, "Colorado Dotson", "(058) 41455821" },
                    { new Guid("3d9f167c-fd78-4528-908f-56f225bda9f7"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5675), null, null, null, "Lamar Robles", "(00593) 5308822" },
                    { new Guid("b7960439-9b58-4114-b77b-efa948c2b30e"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5672), null, null, null, "Alexander Hendrix", "(06494) 3685877" },
                    { new Guid("10d94b12-0d6f-4298-a308-9de65428b6c7"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5712), null, null, null, "Lamar Robles", "(00593) 5308822" },
                    { new Guid("aa766321-3e5d-4987-9318-42b42ed8820c"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5670), null, null, null, "Rebekah Mooney", "(0977) 85347403" },
                    { new Guid("da254a2a-f4b4-41a1-8cbc-e40a66b6ee8a"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5714), null, null, null, "Colorado Dotson", "(058) 41455821" },
                    { new Guid("7190bdd1-b163-4321-be65-df14272ab91a"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5717), null, null, null, "Elijah Mueller", "(032476) 601138" },
                    { new Guid("0a0cbbef-d00a-4c6f-a76f-5e165feb10e3"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5781), null, null, null, "Lana Hudson", "(095) 35767831" },
                    { new Guid("592eb875-8e0b-4aa3-97b7-9dd7d45608f1"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5780), null, null, null, "Elijah Mueller", "(032476) 601138" },
                    { new Guid("d1dcbb40-7be0-45d9-aefe-5f54eebc4778"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5778), null, null, null, "Madaline Vinson", "(035) 45331372" },
                    { new Guid("8e118fdf-d25c-4aa1-a48e-207606eeef80"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5776), null, null, null, "Colorado Dotson", "(058) 41455821" },
                    { new Guid("84ff54f7-6921-4be3-b99d-beebed21a2f1"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5775), null, null, null, "Lamar Robles", "(00593) 5308822" },
                    { new Guid("cfcfb616-5fd5-481d-9306-ae591cc778db"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5771), null, null, null, "Alexander Hendrix", "(06494) 3685877" },
                    { new Guid("21cf8088-a8d1-481b-82dc-caa49ed5a6d8"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5769), null, null, null, "Rebekah Mooney", "(0977) 85347403" },
                    { new Guid("a8f126bc-494e-4c72-a00e-4891bb577c07"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5768), null, null, null, "Ocean Glenn", "(035533) 476735" },
                    { new Guid("34ec8436-a9b1-4d6e-97ca-59ae4d82fe0b"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5766), null, null, null, "Tanisha Gutierrez", "(01137) 7162891" },
                    { new Guid("0562fca6-c0db-4703-9ae0-fa29f76238b4"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5764), null, null, null, "Cally Barr", "(0857) 53334108" },
                    { new Guid("f242af96-e7fe-4080-98d1-0ee969c1744c"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5762), null, null, null, "Lana Hudson", "(095) 35767831" },
                    { new Guid("73e0209b-069c-458b-be06-141a8d5f6ddf"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5738), null, null, null, "Elijah Mueller", "(032476) 601138" },
                    { new Guid("5f91d283-8e82-41dd-a8cf-8ce61ff89276"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5736), null, null, null, "Madaline Vinson", "(035) 45331372" },
                    { new Guid("eb2ca997-df14-42f4-8ca4-fe42ed586f2a"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5732), null, null, null, "Colorado Dotson", "(058) 41455821" },
                    { new Guid("8fa4450f-57ce-4c29-812b-ca6e271e2466"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5731), null, null, null, "Lamar Robles", "(00593) 5308822" },
                    { new Guid("828d507f-76d4-4d0d-983a-7216dfc6ba2e"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5729), null, null, null, "Alexander Hendrix", "(06494) 3685877" }
                });

            migrationBuilder.InsertData(
                table: "tblUsersPhoneNumbers",
                columns: new[] { "Id", "AddedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "NameUser", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("70cf664f-0fa6-4d61-be5c-eca9434badf1"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5727), null, null, null, "Rebekah Mooney", "(0977) 85347403" },
                    { new Guid("e1bb89e0-9651-4e05-b892-45dde43606b7"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5726), null, null, null, "Ocean Glenn", "(035533) 476735" },
                    { new Guid("bf1aa53f-c43f-47ce-9e49-7e558026a37f"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5724), null, null, null, "Tanisha Gutierrez", "(01137) 7162891" },
                    { new Guid("b6a78bf8-16f6-4f77-8d85-e5fef4b8e7e0"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5723), null, null, null, "Cally Barr", "(0857) 53334108" },
                    { new Guid("0fe33207-3050-40c7-b459-32e40381c948"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5721), null, null, null, "Lana Hudson", "(095) 35767831" },
                    { new Guid("ed7f3664-9e78-46da-887e-2c84c9da902f"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5716), null, null, null, "Madaline Vinson", "(035) 45331372" },
                    { new Guid("799d8c05-7b3f-4f19-9aa9-5fb1a94a98be"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5668), null, null, null, "Ocean Glenn", "(035533) 476735" },
                    { new Guid("7b464827-361a-451c-b7f9-267def3cc3d7"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5666), null, null, null, "Tanisha Gutierrez", "(01137) 7162891" },
                    { new Guid("5b65a345-a70b-4430-a671-22ea5f714cf3"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5665), null, null, null, "Cally Barr", "(0857) 53334108" },
                    { new Guid("1fc74698-3bcd-456a-8cb8-da0cb89f88f6"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5610), null, null, null, "Rebekah Mooney", "(0977) 85347403" },
                    { new Guid("4c94d5b2-02b0-4b0a-bfda-125d0d08d2c4"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5605), null, null, null, "Ocean Glenn", "(035533) 476735" },
                    { new Guid("133159b1-fc42-4d87-a699-0a48978fa6a5"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5604), null, null, null, "Tanisha Gutierrez", "(01137) 7162891" },
                    { new Guid("4f325d02-c3b3-4256-9e07-374beadbcc07"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5602), null, null, null, "Cally Barr", "(0857) 53334108" },
                    { new Guid("ad3e759d-8fef-4a50-aa58-9a9fb7295000"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5601), null, null, null, "Lana Hudson", "(095) 35767831" },
                    { new Guid("c67df802-bb8b-4e7b-af04-dd8862949904"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5599), null, null, null, "Elijah Mueller", "(032476) 601138" },
                    { new Guid("844934e3-1951-4140-831f-dd57f0b8cbeb"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5597), null, null, null, "Madaline Vinson", "(035) 45331372" },
                    { new Guid("4a69a161-3a25-4b1a-9212-985754165c52"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5595), null, null, null, "Colorado Dotson", "(058) 41455821" },
                    { new Guid("5206c52c-8870-4172-8e6c-7516c36502d6"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5556), null, null, null, "Lamar Robles", "(00593) 5308822" },
                    { new Guid("46df67c5-7264-4cd3-88b6-b0e8366532b5"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5552), null, null, null, "Alexander Hendrix", "(06494) 3685877" },
                    { new Guid("6e873a17-934a-4e58-b482-0b02177aeeb3"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5550), null, null, null, "Rebekah Mooney", "(0977) 85347403" },
                    { new Guid("84286db9-e90a-4b33-8ab7-866c44345512"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5549), null, null, null, "Ocean Glenn", "(035533) 476735" },
                    { new Guid("c8f50ea4-e42c-4a2d-a43b-301ddb667ce7"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5547), null, null, null, "Tanisha Gutierrez", "(01137) 7162891" },
                    { new Guid("a8c47ca3-4f44-4ea3-81f0-689719890aef"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5545), null, null, null, "Cally Barr", "(0857) 53334108" },
                    { new Guid("4ff7bd2b-13db-4f6f-b66f-d44210f5bd06"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5543), null, null, null, "Lana Hudson", "(095) 35767831" },
                    { new Guid("6fe751de-6e00-46fb-b247-a81641e5aa14"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5541), null, null, null, "Elijah Mueller", "(032476) 601138" },
                    { new Guid("19b613c3-72c7-44dd-91b8-381c7ca6a06d"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5539), null, null, null, "Madaline Vinson", "(035) 45331372" },
                    { new Guid("7e77e20b-bb38-42ac-a9db-df6493bb460d"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5528), null, null, null, "Colorado Dotson", "(058) 41455821" },
                    { new Guid("5aed1329-3a1a-41f5-b760-883a23681f2b"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5526), null, null, null, "Lamar Robles", "(00593) 5308822" },
                    { new Guid("0b4641b9-30c0-494f-a43c-9da7447b8476"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5523), null, null, null, "Alexander Hendrix", "(06494) 3685877" },
                    { new Guid("c80279a5-c139-4244-af9f-0530e4d158fa"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5510), null, null, null, "Ahmed2", "01009615946" },
                    { new Guid("79afc65a-4474-4393-9d06-4c8fbefae4af"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5611), null, null, null, "Alexander Hendrix", "(06494) 3685877" },
                    { new Guid("b48c30d1-5003-4602-96dc-e5f2b6df1d20"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5613), null, null, null, "Lamar Robles", "(00593) 5308822" },
                    { new Guid("adbd43e3-f68e-4bcd-ad97-c0364cf1f156"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5614), null, null, null, "Colorado Dotson", "(058) 41455821" },
                    { new Guid("0c8aa046-b13b-4210-837b-796148b7d657"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5616), null, null, null, "Madaline Vinson", "(035) 45331372" },
                    { new Guid("57f1ff90-60b8-4340-94ee-f940d0c0604d"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5663), null, null, null, "Lana Hudson", "(095) 35767831" },
                    { new Guid("9c263c25-4ec9-48b8-8a63-3d988bf19b5c"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5662), null, null, null, "Elijah Mueller", "(032476) 601138" },
                    { new Guid("e9d38810-d128-4a29-b733-e0711a7b1bf5"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5660), null, null, null, "Madaline Vinson", "(035) 45331372" },
                    { new Guid("5de995fa-a82a-4971-8d38-98ce235a4203"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5656), null, null, null, "Colorado Dotson", "(058) 41455821" },
                    { new Guid("cdc6aa48-7dd7-4a2b-9765-36470c50f6e4"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5654), null, null, null, "Lamar Robles", "(00593) 5308822" },
                    { new Guid("dc6e89b3-cd8b-4b3c-a459-582886c35104"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5651), null, null, null, "Alexander Hendrix", "(06494) 3685877" },
                    { new Guid("01dd2ba2-5ef7-4c35-9190-e16a26b2bdfc"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5648), null, null, null, "Rebekah Mooney", "(0977) 85347403" },
                    { new Guid("05d6294e-e436-4932-ab5b-a582b50dcede"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5647), null, null, null, "Ocean Glenn", "(035533) 476735" }
                });

            migrationBuilder.InsertData(
                table: "tblUsersPhoneNumbers",
                columns: new[] { "Id", "AddedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "NameUser", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("ceb0784f-c91a-48e2-a7b0-e8e6ea710b33"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5645), null, null, null, "Tanisha Gutierrez", "(01137) 7162891" },
                    { new Guid("5852cd17-e8d9-47dc-8991-2a99df846790"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5643), null, null, null, "Cally Barr", "(0857) 53334108" },
                    { new Guid("196bfb65-4261-4dd7-8f52-029c3c5e12ca"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5783), null, null, null, "Cally Barr", "(0857) 53334108" },
                    { new Guid("8fcac0dd-1cb4-4c51-9123-149c3080076a"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5642), null, null, null, "Lana Hudson", "(095) 35767831" },
                    { new Guid("65ced119-24aa-4aa0-8073-6e8db76248ef"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5637), null, null, null, "Madaline Vinson", "(035) 45331372" },
                    { new Guid("5d8dac19-637f-41a5-996d-179f4bd87cd4"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5635), null, null, null, "Colorado Dotson", "(058) 41455821" },
                    { new Guid("8ea875ed-07e4-4d07-a89e-9fab6ec534d9"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5633), null, null, null, "Lamar Robles", "(00593) 5308822" },
                    { new Guid("1becc2d6-f76f-4358-8ffd-10d80f04b25d"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5630), null, null, null, "Alexander Hendrix", "(06494) 3685877" },
                    { new Guid("3c6973f5-b53d-41a3-b154-b7b1599abd7f"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5629), null, null, null, "Rebekah Mooney", "(0977) 85347403" },
                    { new Guid("522fedd6-3dc2-4f86-9e2b-a5662ac8b6ef"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5627), null, null, null, "Ocean Glenn", "(035533) 476735" },
                    { new Guid("e5a20fdb-e668-4331-bf04-f808f060ef4d"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5626), null, null, null, "Tanisha Gutierrez", "(01137) 7162891" },
                    { new Guid("51553e57-9956-41b5-9a63-c706e860a725"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5622), null, null, null, "Cally Barr", "(0857) 53334108" },
                    { new Guid("313b3267-2d09-419e-8e7e-9dc20383131e"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5620), null, null, null, "Lana Hudson", "(095) 35767831" },
                    { new Guid("50bfeed8-cccc-4510-902e-d902f25afd89"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5618), null, null, null, "Elijah Mueller", "(032476) 601138" },
                    { new Guid("6eb3b6b0-6c8a-4ab1-9060-b68abe14463d"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5638), null, null, null, "Elijah Mueller", "(032476) 601138" },
                    { new Guid("6ebba8f9-6210-44f4-94d0-141ad59e90cb"), new DateTime(2022, 2, 26, 7, 12, 56, 695, DateTimeKind.Local).AddTicks(5785), null, null, null, "Tanisha Gutierrez", "(01137) 7162891" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblSendMessage_UserId",
                table: "tblSendMessage",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblSendMessage");

            migrationBuilder.DropTable(
                name: "tblUsersPhoneNumbers");
        }
    }
}
