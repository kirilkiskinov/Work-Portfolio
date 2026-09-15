% ANFIS example: Modeling a nonlinear function using training data

% Step 1: Generate training data
x = (0:0.1:10)';
y = sin(x);  % Target function

data = [x y];  % Combine input and output into one matrix

% Step 2: Generate initial FIS structure using grid partitioning
numMFs = 3;              % Number of membership functions
mfType = 'gaussmf';      % Type of membership function

% Create the initial FIS for ANFIS training
init_fis = genfis1(data, numMFs, mfType);

% Step 3: Train the ANFIS system using training data
epochs = 20;
[trained_fis, training_error] = anfis(data, init_fis, epochs);

% Step 4: Evaluate the trained system
y_predicted = evalfis(x, trained_fis);

% Step 5: Plot training error
figure;
plot(1:epochs, training_error, 'r-o');
xlabel('Epoch');
ylabel('Training Error');
title('Training Error vs. Epoch');

% Step 6: Plot actual vs predicted output
figure;
plot(x, y, 'b', 'LineWidth', 1.5); hold on;
plot(x, y_predicted, 'r--', 'LineWidth', 1.5);
legend('Actual Output (sin(x))', 'ANFIS Output');
xlabel('x');
ylabel('y');
title('ANFIS Approximation of sin(x)');
