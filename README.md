# ODBC Tester

Simple console application that tries to connect to a known non existent end point to determine if the ODBC driver can be found. Was developed to test ODBC drivers being installed via a bosh add-on. 

### Driver not found: 

~~~~
[ERR] Error occured, System.Data.Odbc.OdbcException (0x80131937): 
    ERROR [IM002] [Microsoft][ODBC Driver Manager] Data source name not found and no default 
    driver specified
