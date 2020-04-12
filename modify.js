const fetch = require("node-fetch");
const fs = require("fs");
const lodash = require("lodash");

async function run() {
  const req = await fetch(
    "https://raw.githubusercontent.com/Bungie-net/api/master/openapi-2.json"
  );

  const apiSpec = await req.json();

  const modified = lodash.cloneDeepWith(
    apiSpec,
    (value, key, _object, _stack) => {
      let newValue = value;

      if (
        lodash.isObject(value) &&
        value.format === "byte" &&
        value.type === "string"
      ) {
        newValue = {
          ...value,
          type: "integer",
        };
      }

      if (lodash.isString(value) && value === "uint32") {
        newValue = "int64";
      }

      if (newValue !== value) {
        console.log(
          `REPLACING ${JSON.stringify(value)} with ${JSON.stringify(
            newValue
          )} for key "${key}"`
        );

        return newValue;
      }
    }
  );

  fs.writeFileSync(
    "./openapi-2-modified.json",
    JSON.stringify(modified, null, 2)
  );
}

run();
