import 'package:flutter/material.dart';
import 'package:font_awesome_flutter/font_awesome_flutter.dart';

class OfflinePasswords extends StatefulWidget {
  @override
  _OfflinePasswordsState createState() => _OfflinePasswordsState();
}

class _OfflinePasswordsState extends State<OfflinePasswords> {
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
    return Padding(
      padding: EdgeInsets.symmetric(horizontal: 20, vertical: 20),
      child: ListView(
      children: <Widget>[
        Card(
          child: ListTile(
            leading: Icon(Icons.ac_unit),
            title: Text('Facebook Şifresi'),
            trailing: Icon(Icons.more_vert),
          ),
        ),
        Card(
          child: ListTile(
            leading: Icon(Icons.ac_unit),
            title: Text('Facebook Şifresi'),
            trailing: Icon(Icons.more_vert),
          ),
        ),
        Card(
          child: ListTile(
            leading: Icon(Icons.ac_unit),
            title: Text('Facebook Şifresi'),
            trailing: Icon(Icons.more_vert),
          ),
        ),
        Card(
          child: ListTile(
            leading: Icon(Icons.ac_unit),
            title: Text('Facebook Şifresi'),
            trailing: Icon(Icons.more_vert),
          ),
        ),
        Card(
          child: ListTile(
            leading: Icon(Icons.ac_unit),
            title: Text('Facebook Şifresi'),
            trailing: Icon(Icons.more_vert),
          ),
        ),
        
      ],
    ),
    );
  }
}
