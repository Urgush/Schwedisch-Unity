using System.Data;
using UnityEngine;
using Mono.Data.Sqlite;
using System;
using TMPro;

public class DBTest : MonoBehaviour
{
    string zeile;
    public TextMeshProUGUI canvastext;

    void Start()
    {
        string conn = "URI=file:" + Application.dataPath + "/StreamingAssets/Schwedisch.db"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "SELECT substantiv_id, singular_unbestimmt_schwedisch " + "FROM substantiv";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            int value = reader.GetInt32(0);
            string name = reader.GetString(1);

            Debug.Log("value= " + value + "  name =" + name);
            zeile += value + " " + name + Environment.NewLine;
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;

        canvastext.text = zeile;
    } 
}

