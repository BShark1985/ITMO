import math

d1 = float(input('Введите кратчайшее кратчайшее расстояние между спасателем и кромкой воды, d1 (ярды) => ')) #8
d2 = float(input('Введите кратчайшее расстояние от утопающего до берега, d2 (футы) => ')) #10
h = float(input('Введите боковое смещение между спасателем и утопающим, h (ярды) => ')) #50
v_sand = float(input('Введите скорость движения спасателя по песку, v_sand (мили в час) => ')) #5
n = float(input('Введите коэффициент замедления спасателя при движении в воде, n => ')) #2
theta1 = float(input('Введите направление движения спасателя по песку, theta1 (градусы) => ')) #39.413

koeffyardstofoot = 3
koeffmilestofoot = 5280
secinhour = 3600
koeffgradtorad = 57.295782

L1 = (d1 * koeffyardstofoot) / math.cos((theta1 / koeffgradtorad))
x = L1 * math.sin((theta1 / koeffgradtorad))
L2 = math.sqrt(((h * koeffyardstofoot)-x)**2 + d2**2)
t = L1 / (v_sand * koeffmilestofoot / secinhour) + L2 / ((v_sand * koeffmilestofoot / secinhour)/n)

print(t)

print('Если спасатель начнёт движение под углом theta1, равным ', {theta1}, ' градусам, он достигнет утопащего через', str(round(t , 1)), ' секунды')