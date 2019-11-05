import 'package:flutter/material.dart';

class SelectMode extends StatefulWidget {
  @override
  _SelectModeState createState() => _SelectModeState();
}

class _SelectModeState extends State<SelectMode> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[
            Text(
              "Passku",
              style: TextStyle(
                fontSize: 50,
              ),
            ),
            SizedBox(
              height: 10,
            ),
            Container(
              color: Colors.black,
              width: MediaQuery.of(context).size.width * 0.90,
              height: 1,
            ),
            SizedBox(
              height: 50,
            ),
            ButtonTheme(
              minWidth: 350,
              height: 60,
              child: FlatButton(
                shape: new RoundedRectangleBorder(
                    borderRadius: new BorderRadius.circular(18.0),
                    side: BorderSide(color: Colors.black)),
                color: Colors.white,
                textColor: Colors.black,
                padding: EdgeInsets.all(8.0),
                onPressed: () {
                  Navigator.pushNamed(context, "/login");
                },
                child: Text(
                  "Login Passku",
                  style: TextStyle(
                    fontSize: 25.0,
                  ),
                ),
              ),
            ),
            SizedBox(
              height: 30,
            ),
            ButtonTheme(
              minWidth: 350,
              height: 60,
              child: FlatButton(
                shape: new RoundedRectangleBorder(
                    borderRadius: new BorderRadius.circular(18.0),
                    side: BorderSide(color: Colors.black)),
                color: Colors.white,
                textColor: Colors.black,
                padding: EdgeInsets.all(8.0),
                onPressed: () {},
                child: Text(
                  "Use Offline Mode",
                  style: TextStyle(
                    fontSize: 25.0,
                  ),
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}
