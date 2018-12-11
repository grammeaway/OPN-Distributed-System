#!/bin/bash
set -e
run_cmd="dotnet bin/Debug/netcoreapp2.1/publish/backend1.dll"


until dotnet ef database drop -f; do
>&2 echo "SQL Server is starting up"
sleep 1
done

until dotnet ef database update; do
>&2 echo "SQL Server is starting up"
sleep 1
done

>&2 echo "SQL Server is up - executing command"
exec $run_cmd