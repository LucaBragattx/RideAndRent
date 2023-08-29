<%@ Page Title="" Language="C#" MasterPageFile="~/View/Inspector/InspectorMaster.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="RideYouRentST10090990.View.Inspector.Cars" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <div class="row">
                    <div class="col"></div>
                    <h3 class="text-success">Manage Cars</h3>
                    <div class="col"><img src="../../Assets/Img/rental.png" height="130px"></div>
                    <div class="col"></div>
                </div>
                <div class="row">
                    <div class="col">
                        <form runat="server">
                            <div class="form group">
                                <label for="exampleInputEmail1" class="form-label">Car Number</label>
                                <input type="text" class="form-control" id="CarNo1" placeholder="Enter Car Number" runat="server">
                           </div>
                            <div class="form group">
                                <label for="exampleInputEmail1" class="form-label">Car Make</label>
                                <input type="text" class="form-control" id="CarMake1" placeholder="Enter Car Make" runat="server">
                           </div>
                            <div class="form group">
                                <label for="exampleInputEmail1" class="form-label">Car Model</label>
                                <input type="text" class="form-control" id="CarModel1" placeholder="Enter Car Model" runat="server">
                           </div>
                            <div class="form group">
                                <label for="exampleInputEmail1" class="form-label">Car Body Type</label>
                                <input type="text" class="form-control" id="CarBodyType1" placeholder="Enter Car Body Type" runat="server">
                           </div>
                            <div class="form group">
                                <label for="exampleInputEmail1" class="form-label">Kilometres Travelled</label>
                                <input type="text" class="form-control" id="KilometresTravelled1" placeholder="Enter Kilometres Travelled" runat="server">
                           </div>
                            <div class="form group">
                                <label for="exampleInputEmail1" class="form-label">Service Kilometres</label>
                                <input type="text" class="form-control" id="ServiceKilometres1" placeholder="Enter Service Kilometres" runat="server">
                           </div>
                            <div class="form group">
                                <label for="exampleInputEmail1" class="form-label">Avaliable</label>
                                <asp:DropDownList ID="Avaliable1" runat="server" class="form-control">
                                    <asp:ListItem>yes</asp:ListItem>
                                    <asp:ListItem>no</asp:ListItem>
                                </asp:DropDownList>
                           </div>
                            <br />
                            <label id="ErrorMsg" runat="server" class="text-danger"></label> <br />
                            <asp:Button type="submit" ID="CreateBtn" class="btn btn-danger" Text="Create" runat="server" OnClick="CreateBtn_Click"/>
                            <asp:Button type="submit" ID="ReadBtn" class="btn btn-danger" Text="Read" runat="server"/>
                            <asp:Button type="submit" ID="UpdateBtn" class="btn btn-danger" Text="Update" runat="server" OnClick="UpdateBtn_Click"/>
                            <asp:Button type="submit" ID="DeleteBtn" class="btn btn-danger" Text="Delete" runat="server" OnClick="DeleteBtn_Click"/>
                        </form>

                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <h1>Cars List</h1>
                <asp:GridView runat="server" ID="CarList" Class="table" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CarList_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="#009933" ForeColor="#000000" />

                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
