import "package:flutter/material.dart";
import 'package:font_awesome_flutter/font_awesome_flutter.dart';

class OfflineAbout extends StatefulWidget {
  @override
  _OfflineAboutState createState() => _OfflineAboutState();
}

class _OfflineAboutState extends State<OfflineAbout> {
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
                              "About ?",
                              style:
                                  Theme.of(context).textTheme.display1.copyWith(
                                        color: Colors.white,
                                        fontSize: 24.0,
                                      ),
                            ),
                            trailing: Icon(
                              FontAwesomeIcons.infoCircle,
                              color: Colors.white,
                            ),
                          ),
                          Padding(
                            padding: const EdgeInsets.only(left: 16.0),
                            child: Text(
                              'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',
                              style: whiteText,
                            ),
                          )
                        ],
                      ),
                    ),
                    const SizedBox(height: 10.0),
                    Container(
                      height: 150,
                      color: Colors.green,
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: <Widget>[
                          ListTile(
                            title: Text(
                              "Contact",
                              style:
                                  Theme.of(context).textTheme.display1.copyWith(
                                        color: Colors.white,
                                        fontSize: 24.0,
                                      ),
                            ),
                            trailing: Icon(
                              FontAwesomeIcons.phone,
                              color: Colors.white,
                            ),
                          ),
                          Padding(
                            padding: const EdgeInsets.only(left: 16.0),
                            child: Text(
                              'contact: info@passku.online\nDeveloper: Berke Kurnaz',
                              style: whiteText,
                            ),
                          )
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
