const D2Manifest = require("destiny2-manifest").default;

const manifest = new D2Manifest("asdf");

const iconPlaceholder = /(\[[^\]]+\]|[\uE000-\uF8FF])/g;

// Copy-pasted from DIM
const table = [
  // Damage Types
  { objectiveHash: 2178780271, unicode: "", substring: null },
  { objectiveHash: 220763483, unicode: "", substring: null }, // Void
  { objectiveHash: 2994623161, unicode: "", substring: null },
  { objectiveHash: 1554970245, unicode: "", substring: null },
  // Precision
  { objectiveHash: 2499602007, unicode: "", substring: null },
  // Abilities
  { objectiveHash: 314405660, unicode: "", substring: null },
  { objectiveHash: 3711356257, unicode: "", substring: null },
  // All Rifle-class
  { objectiveHash: 532914921, unicode: "", substring: null },
  { objectiveHash: 2161000034, unicode: "", substring: null },
  { objectiveHash: 2062881933, unicode: "", substring: null },
  { objectiveHash: 3527067345, unicode: "", substring: null },
  { objectiveHash: 3296270292, unicode: "", substring: null },
  { objectiveHash: 3080184954, unicode: "", substring: null },
  { objectiveHash: 3057562910, unicode: "", substring: null },
  // Remaining weapons, that are not heavy
  { objectiveHash: 53304862, unicode: "", substring: null },
  { objectiveHash: 635284441, unicode: "", substring: null },
  { objectiveHash: 2722409947, unicode: "", substring: null },
  { objectiveHash: 1242546978, unicode: "", substring: null },
  { objectiveHash: 299893109, unicode: "", substring: null },
  { objectiveHash: 3057562910, unicode: "", substring: null },
  // Heavy Weapons
  { objectiveHash: 2152699013, unicode: "", substring: null },
  { objectiveHash: 2203404732, unicode: "", substring: null },
  { objectiveHash: 1788114534, unicode: "", substring: null },
  { objectiveHash: 989767424, unicode: "", substring: null },
  // Artifacts that can be picked up and used as weapons
  { objectiveHash: 4231452845, unicode: "", substring: null },
  // Gambit - Blockers
  { objectiveHash: 276438067, unicode: "", substring: null },
  { objectiveHash: 3792840449, unicode: "", substring: null },
  { objectiveHash: 2031240843, unicode: "", substring: null },
  // Quest Markers
  { objectiveHash: 3915460773, unicode: "", substring: null },
  // Breakers
  { objectiveHash: 3068403538, unicode: "", substring: null },
  { objectiveHash: 2678922819, unicode: "", substring: null },
  { objectiveHash: 3879088617, unicode: "", substring: null },
];

async function run() {
  await manifest.load();

  const data = [];

  table.forEach((iconEntry) => {
    const objectiveDef = manifest.get(
      "DestinyObjectiveDefinition",
      iconEntry.objectiveHash
    );

    if (!objectiveDef) {
      console.log("no objective for hash", iconEntry.objectiveHash);
      return;
    }

    // lookup this lang's string for the objective
    const progressDescriptionMatch = objectiveDef.progressDescription.match(
      iconPlaceholder
    );

    const iconString = progressDescriptionMatch && progressDescriptionMatch[0];
    // this language's localized replacement, which we will detect and un-replace back into an icon
    iconEntry.substring = iconString;

    if (iconString) {
      data.push({ unicode: iconEntry.unicode, substring: iconString });
    }
  });

  console.log(data);

  const rows = data
    .map((icon) => `new [] {"${icon.substring}", "${icon.unicode}"}`)
    .join(",\n");

  const code = `
      var icons = new []
      {
          ${rows}
      };
    `;

  console.log("\n\n");

  console.log(code);
}

run();
