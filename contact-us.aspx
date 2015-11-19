<%@ Page Language="C#" AutoEventWireup="true" CodeFile="contact-us.aspx.cs" Inherits="contact_us" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    
     <title>Improwin Solutions.</title>

    <!-- core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/prettyPhoto.css" rel="stylesheet" />
    <link href="css/animate.min.css" rel="stylesheet" />
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/responsive.css" rel="stylesheet" />

    <!--[if lt IE 9]>
    <script src="js/html5shiv.js"></script>
    <script src="js/respond.min.js"></script>
    <![endif]-->
    <link rel="shortcut icon" href="images/ico/improwin_4.jpg" />
    <script>
//$(document).ready(function() {
//    // Generate a simple captcha
//    function randomNumber(min, max) {
//        return Math.floor(Math.random() * (max - min + 1) + min);
//    }
//    $('#captchaOperation').html([randomNumber(1, 100), '+', randomNumber(1, 200), '='].join(' '));

//    $('#contactUs').formValidation({
//        framework: 'bootstrap',
//        icon: {
//            valid: 'glyphicon glyphicon-ok',
//            invalid: 'glyphicon glyphicon-remove',
//            validating: 'glyphicon glyphicon-refresh'
//        },
//        fields: {
//            firstName: {
//                row: '.col-xs-4',
//                validators: {
//                    notEmpty: {
//                        message: 'The first name is required'
//                    }
//                }
//            },
//            lastName: {
//                row: '.col-xs-4',
//                validators: {
//                    notEmpty: {
//                        message: 'The last name is required'
//                    }
//                }
//            },
//            username: {
//                validators: {
//                    notEmpty: {
//                        message: 'The username is required'
//                    },
//                    stringLength: {
//                        min: 6,
//                        max: 30,
//                        message: 'The username must be more than 6 and less than 30 characters long'
//                    },
//                    regexp: {
//                        regexp: /^[a-zA-Z0-9_\.]+$/,
//                        message: 'The username can only consist of alphabetical, number, dot and underscore'
//                    }
//                }
//            },
//            email: {
//                validators: {
//                    notEmpty: {
//                        message: 'The email address is required'
//                    },
//                    emailAddress: {
//                        message: 'The input is not a valid email address'
//                    }
//                }
//            },
//            password: {
//                validators: {
//                    notEmpty: {
//                        message: 'The password is required'
//                    },
//                    different: {
//                        field: 'username',
//                        message: 'The password cannot be the same as username'
//                    }
//                }
//            },
//            gender: {
//                validators: {
//                    notEmpty: {
//                        message: 'The gender is required'
//                    }
//                }
//            },
//            captcha: {
//                validators: {
//                    callback: {
//                        message: 'Wrong answer',
//                        callback: function(value, validator, $field) {
//                            var items = $('#captchaOperation').html().split(' '), sum = parseInt(items[0]) + parseInt(items[2]);
//                            return value == sum;
//                        }
//                    }
//                }
//            },
//            agree: {
//                validators: {
//                    notEmpty: {
//                        message: 'You must agree with the terms and conditions'
//                    }
//                }
//            }
//        }
//    });
//});
</script>
</head><!--/head-->
<body>
    <form id="contactUs" class="contact-form" runat="server">
    <div id="headerContent"></div>
    <section id="contact-info">
        <div class="center">
            <h2>How to Reach Us?</h2>
            <p class="lead">Tell us about your expectation so we can give you the right solution.</p>
            <asp:Label ID="lbl_sendmessage" runat="server" CssClass="alert alert-success fade in" Visible="false"></asp:Label>
        </div>
        <div class="footer_div">
            <div class="container">
                <div class="row">
                    <div class="col-sm-5 text-center">
                       
                         <div class="gmap">
                            <iframe style="height:130%;width:100%;border:0;margin-top:-75px;"  src="https://www.google.com/maps/embed/v1/place?q=Kolkata,+West+Bengal,+India&key=AIzaSyAN0om9mFmy1QN6Wf54tXAowK4eT0ZUPrU">
                                 
                                     </iframe>
                           
            
                        </div>

                    </div>
                    <div class="col-sm-5 col-sm-offset-1 clumn_box">
                         <h5> Improwin Software Solutions </h5>
                        <p> Web Design Company, India. Checkout.com, Inc. is an authorized retailer of Improwin Software Solutions </p> <hr />
                        <p>Improwin Solutions.&nbsp;&nbsp;        <i class="fa fa-clock-o"> 9am to 6pm</i>   <br />Shatabdi Park, Block E Kolkata - 700099</p> 
                        <p><i class="fa fa-envelope"></i>&nbsp; <a href="mailto:info@improwindolutions.com">info@improwindolutions.com</a> </p>
                                
                    </div>
                    
                   
                </div>
            </div>
        </div>
    </section>  <!--/gmap_area -->
        <!--Start-->
         
        <!--End-->
    <section id="contact-page">
        <div class="container">
            <div class="center">
                <h2>Drop Your Message</h2>
                <p class="lead">To learn more about whether our services are right for your business need, please complete the form below.</p>
                
            </div>
            <!--Start-->
             <div class="row contact-wrap">
                <div class="status alert alert-success" style="display: none"></div>
                
                    <div class="col-sm-5 col-sm-offset-1">
                        <div class="form-group">
                            <label>Name *</label>
                            <asp:TextBox  CssClass="form-control" runat="server" name="name" ID="name" ClientIDMode="Static" required="required" ></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Email *</label>
                             <asp:TextBox ID="txtEmail"  CssClass="form-control" ClientIDMode="Static" name="email" runat="server" required="required"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Phone</label>
                            <asp:TextBox ID="txtPhone" CssClass="form-control" runat="server" ClientIDMode="Static"  ></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Company Name</label>
                             <asp:TextBox ID="txtCompanyName" CssClass="form-control" runat="server" ClientIDMode="Static" required="required" ></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-sm-5">
                        <div class="form-group">
                            <label>Subject *</label>
                            <asp:TextBox ID="txtSubject" CssClass="form-control" runat="server" ClientIDMode="Static" required="required" ></asp:TextBox>
                           
                        </div>
                        <div class="form-group">
                            <label>Message *</label>
                            
                             <asp:TextBox ID="txtMessage" TextMode="MultiLine" Rows="8" CssClass="form-control" runat="server" ClientIDMode="Static" required="required" ></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary btn-lg" Text="Submit Message"  OnClick="btnSubmit_Click" />
                        </div>
                    </div>
               
            </div><!--/.row-->
       
            <!--End-->
          
        </div><!--/.container-->
    </section><!--/#contact-page-->
   
    <div id="footerContent"></div>
    <!--/#footer-->
        </form>
    <script src="js/jquery.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.prettyPhoto.js"></script>
    <script src="js/jquery.isotope.min.js"></script>
    <script src="js/main.js"></script>
    <script src="js/wow.min.js"></script>
    <script>

    $(function(){
      $("#headerContent").load("header.html")
    });
    $(function () {
        $("#footerContent").load("footer.html")
    });
    </script>
</body>
</html>