# curl https://raw.githubusercontent.com/Bungie-net/api/master/openapi-2.json | sed 's/uint32/int64/g' > openapi-2-modified.json
node ./modify.js
openapi-generator generate -i ./openapi-2-modified.json -g csharp-netcore -o ./csharp-netcore-modified --skip-validate-spec -c ./config.json