<%@ Page Title="" Language="C#" MasterPageFile="~/View/Inspector/InspectorMaster.Master" AutoEventWireup="true" CodeBehind="Drivers.aspx.cs" Inherits="RideYouRentST10090990.View.Inspector.Drivers" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mybody" runat="server">
    
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <div class="row">
                    <div class="col"></div>
                    <h4 class="text-success">Manage Drivers</h4>
                    <div class="col"><img src="../../Assets/Img/login.jpg" height="130px"></div>
                    <div class="col"></div>
                </div>
                <div class="row">
                    <div class="col">
                        <form runat="server">
                            <div class="form group">
                                <label for="exampleInputEmail1" class="form-label">Driver Name</label>
                                <input type="text" class="form-control" id="DriverName1" placeholder="Enter Driver Name" runat="server">
                           </div>
                            <div class="form group">
                                <label for="exampleInputEmail1" class="form-label">Driver Address</label>
                                <input type="text" class="form-control" id="DriverAddress1" placeholder="Enter Driver Address" runat="server">
                           </div>
                            <div class="form group">
                                <label for="exampleInputEmail1" class="form-label">Driver Email</label>
                                <input type="text" class="form-control" id="DriverEmail1" placeholder="Enter Driver Email" runat="server">
                           </div>
                            <div class="form group">
                                <label for="exampleInputEmail1" class="form-label">Driver Mobile</label>
                                <input type="text" class="form-control" id="DriverMobile1" placeholder="Enter Driver Mobile Number" runat="server">
                           </div>
                            <br />
                            
                            <label id="ErrorMsg" runat="server" class="text-danger"></label> <br />
                            <asp:Button type="submit" ID="CreateBtn" class="btn btn-danger" Text="Create" runat="server" OnClick="CreateBtn_Click1"/>
                            <asp:Button type="submit" ID="ReadBtn" class="btn btn-danger" Text="Read" runat="server"/>
                            <asp:Button type="submit" ID="UpdateBtn" class="btn btn-danger" Text="Update" runat="server" OnClick="UpdateBtn_Click"/>
                            <asp:Button type="submit" ID="DeleteBtn" class="btn btn-danger" Text="Delete" runat="server" OnClick="DeleteBtn_Click"/>
                        </form>

                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <h1>Drivers List</h1>
                <asp:GridView runat="server" ID="DriverList" Class="table" AutoGenerateSelectButton="True" OnSelectedIndexChanged="DriverList_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="#009933" ForeColor="#000000" />

                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
