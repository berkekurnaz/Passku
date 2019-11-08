import 'package:flutter/material.dart';

import 'package:passku/screens/landingPages/forgotPassword.dart';
import 'package:passku/screens/landingPages/login.dart';
import 'package:passku/screens/landingPages/register.dart';
import 'package:passku/screens/landingPages/selectMode.dart';
import 'package:passku/screens/offlinePages/offlineAbout.dart';
import 'package:passku/screens/offlinePages/offlineCreate.dart';

import 'package:passku/screens/offlinePages/offlineHome.dart';
import 'package:passku/screens/offlinePages/offlineHowToUse.dart';
import 'package:passku/screens/offlinePages/offlinePasswords.dart';

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

      "/offlineHome": (context) => OfflineHome(),
      "/offlineHowToUse": (context) => OfflineHowToUse(),
      "/offlineAbout": (context) => OfflineAbout(),
      "/offlineCreate": (context) => OfflineCreate(),
      "/offlinePasswords": (context) => OfflinePasswords(),
    },
  ));
}