<%@ Page Title="" Language="C#" MasterPageFile="~/View/Driver/DriverMaster.Master" AutoEventWireup="true" CodeBehind="Pending.aspx.cs" Inherits="RideYouRentST10090990.View.Driver.Pending" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col"></div>
            <div class="col"><h2>Your Pending Rentals</h2>

            </div>
            <div class="col"></div>
        </div>
        <div class="row">
        <form runat="server">
            <div class="col-md-8">
            <asp:GridView runat="server" ID="CarList" Class="table table-hover">
                    <AlternatingRowStyle BackColor="#009933" ForeColor="#000000" />

                </asp:GridView>
            </div>
        </form>
            </div>
            </div>
    
</asp:Content>

