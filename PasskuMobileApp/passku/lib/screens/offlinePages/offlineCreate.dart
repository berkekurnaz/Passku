import 'package:flutter/material.dart';
import 'package:font_awesome_flutter/font_awesome_flutter.dart';

class OfflineCreate extends StatefulWidget {
  @override
  _OfflineCreateState createState() => _OfflineCreateState();
}

class _OfflineCreateState extends State<OfflineCreate> {
  static final String path = "lib/src/pages/misc/dash2.dart";
  final TextStyle whiteText = TextStyle(color: Colors.white);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.grey.shade800,
      appBar: AppBar(
        backgroundColor: Colors.transparent,
        elevation: 0,
        title: Text("Passku - Offline Mode"),
        centerTitle: true,
      ),
      body: _buildBody(context),
    );
  }

  Widget _buildBody(BuildContext context) {
    return SingleChildScrollView(
      padding: const EdgeInsets.all(16.0),
      child: Column(
        children: <Widget>[
          _buildHeader(),
          const SizedBox(height: 50.0),
          Row(
            children: <Widget>[
              Expanded(
                child: Column(
                  children: <Widget>[
                    Container(
                      height: 250,
                      color: Colors.blue,
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: <Widget>[
                          ListTile(
                            title: Text(
                              "Create Password",
                              style:
                                  Theme.of(context).textTheme.display1.copyWith(
                                        color: Colors.white,
                                        fontSize: 24.0,
                                      ),
                            ),
                            trailing: Icon(
                              FontAwesomeIcons.newspaper,
                              color: Colors.white,
                            ),
                          ),
                          SizedBox(height: 20,),
                          Padding(
                            padding: EdgeInsets.symmetric(horizontal: 30, vertical: 0),
                            child: TextField(
                            decoration: new InputDecoration(
                              labelText: "Your Password",
                              fillColor: Colors.white,
                              border: new OutlineInputBorder(
                                borderRadius: new BorderRadius.circular(25.0),
                                borderSide: new BorderSide(),
                              ),
                            ),
                          ),
                          ),
                          Padding(
                            padding: EdgeInsets.symmetric(horizontal: 40, vertical: 20),
                            child: RaisedButton(
                              onPressed: (){

                              },
                              color: Colors.green,
                              child: Row(
                                mainAxisAlignment: MainAxisAlignment.center,
                                children: <Widget>[
                                  Icon(Icons.create, color: Colors.white),
                                  SizedBox(width: 10,),
                                  Text("Create Password", style: TextStyle(color: Colors.white, fontWeight: FontWeight.bold),)
                                ],
                              ),
                            ),
                          ),
                        ],
                      ),
                    ),
                  ],
                ),
              ),
            ],
          )
        ],
      ),
    );
  }

  Widget _buildHeader() {
    return Row(
      children: <Widget>[
        Container(
          height: 100,
          width: 100,
          padding: const EdgeInsets.all(8.0),
          child: CircularProgressIndicator(
            value: 1,
            valueColor: AlwaysStoppedAnimation(Colors.blue),
            backgroundColor: Colors.grey.shade700,
          ),
        ),
        const SizedBox(width: 20.0),
        Expanded(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: <Widget>[
              Text(
                "Hello\nBerke Kurnaz",
                style: whiteText.copyWith(fontSize: 20.0),
              ),
              const SizedBox(height: 20.0),
              Text(
                "Welcome Your Offline Panel",
                style: TextStyle(color: Colors.grey, fontSize: 16.0),
              ),
            ],
          ),
        )
      ],
    );
  }
}
