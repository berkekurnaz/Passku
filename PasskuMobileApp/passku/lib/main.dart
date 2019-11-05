import 'package:flutter/material.dart';
import 'package:passku/screens/landingPages/forgotPassword.dart';
import 'package:passku/screens/landingPages/login.dart';
import 'package:passku/screens/landingPages/register.dart';
import 'package:passku/screens/landingPages/selectMode.dart';

void main(){
  runApp(MaterialApp(
    initialRoute: "/",
    theme: ThemeData(
      fontFamily: "Montserrat",
      accentColor: Colors.blue,
    ),
    debugShowCheckedModeBanner: false,
    routes: {
      "/": (context) => SelectMode(),
      "/login": (context) => Login(),
      "/register": (context) => Register(),
      "/forgotPassword": (context) => ForgotPassword(),
    },
  ));
}