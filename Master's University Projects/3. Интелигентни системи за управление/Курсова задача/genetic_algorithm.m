% Objective function to be minimized (as anonymous function)
objective = @(x) -(x .* sin(10 * pi * x) + 1);  % We use minus to maximize

% Set lower and upper bounds
lb = 0;   % lower bound
ub = 1;   % upper bound

% Set options for the genetic algorithm
options = gaoptimset('Display','iter','PlotFcns',@gaplotbestf);

% Run the genetic algorithm
[x_opt, fval_opt] = ga(objective, 1, [], [], [], [], lb, ub, [], options);

% Display result
fprintf('Best x found: %.4f\n', x_opt);
fprintf('Maximum value of function: %.4f\n', -fval_opt);
