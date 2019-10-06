from sklearn import tree

#[height, weight, shoe size]
X = [[180, 80, 44], [177, 70, 43],
 [160, 60, 38], [154, 54, 37], [166, 65, 40],
 [190, 90, 47], [175, 64, 39], [177, 70, 40], 
 [159,55,37], [171, 75, 42], [181, 85, 43]]

#['gender assocaited with the measurements']
Y = ['male', 'female', 'female', 'female', 'male',
	'male', 'male', 'female', 'male', 'female', 'male']

classifier = tree.DecisionTreeClassifier()

classifier = classifier.fit(X,Y)

genderPrediction = classifier.predict([[140, 55, 32]]) 

print(genderPrediction)
