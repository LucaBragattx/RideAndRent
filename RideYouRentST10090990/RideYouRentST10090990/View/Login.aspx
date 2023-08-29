<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RideYouRentST10090990.View.Login" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Assets/Libraries/css/bootstrap.min.css" />
</head>
<body>
  <div class="container-fluid">
      <div class="row">
          <div class="col-md-3"></div>
          <div class="col-md-5">
              <div class="row mt-5">
                  <div class="col"></div>
                  <div class="col">
                      <h3 class="ml-5">Ride You Rent Rental Company</h3>
                      <img src="../Assets/Img/login.jpg" height="180px" />
                  </div>
                  <div class="col"></div>
                  </div>

              <form  runat="server">
                  <div class="form-group" runat="server">
        
    <label for="exampleInputEmail">User Name</label>
      <input type="text" class="form-control" id="UserNameTb" aria-describedby="emailHelp" placeholder="Enter User Name" runat="server" required="required">
       <small id="emailHelp" class="form-text text-muted"></small>
    </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Mobile</label>
      <input type="password" class="form-control" id="MobileTb" placeholder="Enter User Mobile" runat="server" required="required">
   </div>
         <div class="form-group">
        <input class="form-check-input" type="radio" id="InspectorRd" name="Role" runat="server">
         <label class="form-check-label" for="exampleCheck1">Inspector</label>
         <input class="form-check-input" type="radio" id="DriverRd" name="Role" runat="server">
        <label class="form-check-label" for="exampleCheck1">Driver</label>
      </div>
              <br />
              <div class="form-group d-grid">
                  <label id="InfoMsg" runat="server"></label>
              <asp:Button type="submit" ID="LoginBtn" class="btn btn-danger btn-block" Text="Login" runat="server" OnClick="LoginBtn_Click"/>
              </div>
                  </form>
      </div>
          <div class="col-md-3"></div>
      </div>
    </div>
</body>
</html>
