import 'package:flutter/material.dart';
import 'package:font_awesome_flutter/font_awesome_flutter.dart';

class OfflineHome extends StatefulWidget {
  @override
  _OfflineHomeState createState() => _OfflineHomeState();
}

class _OfflineHomeState extends State<OfflineHome> {
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
                    GestureDetector(
                      onTap: (){
                        Navigator.pushNamed(context, "/offlinePasswords");
                      },
                      child: Container(
                      height: 190,
                      color: Colors.blue,
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: <Widget>[
                          ListTile(
                            title: Text(
                              "120",
                              style:
                                  Theme.of(context).textTheme.display1.copyWith(
                                        color: Colors.white,
                                        fontSize: 24.0,
                                      ),
                            ),
                            trailing: Icon(
                              FontAwesomeIcons.walking,
                              color: Colors.white,
                            ),
                          ),
                          Padding(
                            padding: const EdgeInsets.only(left: 16.0),
                            child: Text(
                              'Your Offline Passwords Count',
                              style: whiteText,
                            ),
                          )
                        ],
                      ),
                    ),
                    ),
                    const SizedBox(height: 10.0),
                    GestureDetector(
                      onTap: (){
                        Navigator.pushNamed(context, "/offlineAbout");
                      },
                      child: Container(
                      height: 120,
                      color: Colors.green,
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: <Widget>[
                          ListTile(
                            title: Text(
                              "About ?",
                              style:
                                  Theme.of(context).textTheme.display1.copyWith(
                                        color: Colors.white,
                                        fontSize: 24.0,
                                      ),
                            ),
                            trailing: Icon(
                              FontAwesomeIcons.heartbeat,
                              color: Colors.white,
                            ),
                          ),
                          Padding(
                            padding: const EdgeInsets.only(left: 16.0),
                            child: Text(
                              'What Is The Passku ?',
                              style: whiteText,
                            ),
                          )
                        ],
                      ),
                    ),
                    ),
                  ],
                ),
              ),
              const SizedBox(width: 10.0),
              Expanded(
                child: Column(
                  children: <Widget>[
                    GestureDetector(
                      onTap: (){
                        Navigator.pushNamed(context, "/offlineCreate");
                      },
                      child: Container(
                      height: 120,
                      color: Colors.red,
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: <Widget>[
                          ListTile(
                            title: Text(
                              "Create",
                              style:
                                  Theme.of(context).textTheme.display1.copyWith(
                                        color: Colors.white,
                                        fontSize: 24.0,
                                      ),
                            ),
                            trailing: Icon(
                              FontAwesomeIcons.fire,
                              color: Colors.white,
                            ),
                          ),
                          Padding(
                            padding: const EdgeInsets.only(left: 16.0),
                            child: Text(
                              'Create Password',
                              style: whiteText,
                            ),
                          )
                        ],
                      ),
                    ),
                    ),
                    const SizedBox(height: 10.0),
                    GestureDetector(
                      onTap: (){
                        Navigator.pushNamed(context, "/offlineHowToUse");
                      },
                      child: Container(
                      height: 190,
                      color: Colors.yellow,
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: <Widget>[
                          ListTile(
                            title: Text(
                              "How To Use",
                              style:
                                  Theme.of(context).textTheme.display1.copyWith(
                                        fontSize: 24.0,
                                        color: Colors.black,
                                      ),
                            ),
                            trailing: Icon(
                              FontAwesomeIcons.road,
                              color: Colors.black,
                            ),
                          ),
                          Padding(
                            padding: const EdgeInsets.only(left: 16.0),
                            child: Text(
                              'Learn Use To Passku Platform...',
                            ),
                          )
                        ],
                      ),
                    ),
                    ),
                  ],
                ),
              )
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
