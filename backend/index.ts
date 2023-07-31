import express, { Request, Response } from "express";
import cors from "cors";
import sql from "mssql";

const app = express();
const port = 5000;

app.use(express.json());
app.use(cors());
// Create a MySQL connection

// const sqlConfig = {
//   user: "sa",
//   password: "Password123",
//   database: "master",
//   server: '192.168.141.222',
//   pool: {
//     max: 10,
//     min: 0,
//     idleTimeoutMillis: 30000
//   },
//   options: {
//     encrypt: true, // for azure
//     trustServerCertificate: true // change to true for local dev / self-signed certs
//   }
// }
var config = {
  user: "sa",
  password: "Password123",
  server: "localhost",
  database: "master",
  synchronize: true,
  trustServerCertificate: true,
};

app.post("/register", async (req: Request, res: Response) => {
  sql.connect(config, function (err: any) {
    if (err) console.log(err);
    else console.log("Connection successful");

    // create Request object
    const reqSql = new sql.Request();

    const { username, password } = req.body;
    reqSql.query(
      `SELECT * from register.users where username='${username}'`,
      (error: any, data: any) => {
        if (error) {
          console.log(error);
        } else {
          if (data.recordset.length > 0) {
            res.json({ status: 500, msg: "User is not available" });
          } else {
            const sqlStatement = `INSERT INTO register.users (username, passcode) VALUES ('${username}', '${password}')`;
            reqSql.query(sqlStatement, (error: any, results: any) => {
              if (error) {
                console.error("Error registering user:", error);
                if (
                  error.sqlMessage ==
                    "Check constraint 'users_chk_2' is violated." ||
                  error.sqlMessage ==
                    "Check constraint 'users_chk_1' is violated."
                ) {
                  res.json({
                    status: 500,
                    msg: "No empty string allowed for username or password field",
                    error: error,
                  });
                } else {
                  res.json({
                    status: 500,
                    msg: `Failed to register user. ${error}`,
                    error: error,
                  });
                }
              } else {
                console.log("User registered successfully:", results);
                res.json({
                  status: 200,
                  msg: "User registered successfully!!",
                });
              }
            });
          }
        }
      }
    );
  });
});

app.listen(port, () => {
  console.log(`Backend server is running on port ${port}`);
});
