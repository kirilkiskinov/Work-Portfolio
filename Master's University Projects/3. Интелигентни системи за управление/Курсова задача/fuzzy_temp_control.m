% Create fuzzy system
fis = newfis('TemperatureControl');
fis = addvar(fis, 'input', 'Temperature', [0 40]);
fis = addmf(fis, 'input', 1, 'Cold', 'trimf', [0 0 20]);
fis = addmf(fis, 'input', 1, 'Warm', 'trimf', [10 25 40]);
fis = addmf(fis, 'input', 1, 'Hot', 'trimf', [30 40 40]);
fis = addvar(fis, 'output', 'HeaterPower', [0 100]);
fis = addmf(fis, 'output', 1, 'Low', 'trimf', [0 0 50]);
fis = addmf(fis, 'output', 1, 'Medium', 'trimf', [25 50 75]);
fis = addmf(fis, 'output', 1, 'High', 'trimf', [50 100 100]);

% Define rule list as numeric matrix:
ruleList = [
    1 3 1 1 1;  % If Temperature is Cold then HeaterPower is High
    2 2 1 1 1;  % If Temperature is Warm then HeaterPower is Medium
    3 1 1 1 1   % If Temperature is Hot then HeaterPower is Low
];

% Add rules to the system
fis = addrule(fis, ruleList);

% Evaluate the system
temperature_input = 15;
output = evalfis(temperature_input, fis);

fprintf('At %.1f°C, the heater power should be %.2f%%\n', temperature_input, output);

% Visualizations
figure;
plotfis(fis);
figure;
plotmf(fis, 'input', 1);
figure;
plotmf(fis, 'output', 1);
