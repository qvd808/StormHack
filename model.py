import tensorflow as tf
import matplotlib.pyplot as plt
import numpy as np

##Change image to data

IMG_SIZE = 150

from keras.preprocessing.image import ImageDataGenerator

train_data_dir = "./asl_dataset"

train_dataGen = ImageDataGenerator(rescale = 1.0/255)

train_generator = train_dataGen.flow_from_directory(directory = train_data_dir,
                                                    target_size = (IMG_SIZE, IMG_SIZE),
                                                    batch_size = 32,
                                                    )

#Resizing image to make it suitable for apply convolution operation
x_train_resize = np.array(train_generator).reshape(-1, IMG_SIZE, IMG_SIZE, 1)

from tensorflow.keras.models import Sequential
from tensorflow.keras.layers import Dense, Activation, Flatten, Conv2D, MaxPooling2D

model = Sequential()

#First Layer
model.add(Conv2D(128, (3,3), input_shape = x_train_resize[1:]))
model.add(Activation("relu"))
model.add(MaxPooling2D(pool_size = (2,2)))

### 2nd Convolution layer
model.add(Conv2D(128, (3,3)))
model.add(Activation("relu"))
model.add(MaxPooling2D(pool_size = (2,2)))

### 3rd Convolution layer
model.add(Conv2D(128, (3,3)))
model.add(Activation("relu"))
model.add(MaxPooling2D(pool_size = (2,2)))

##Fully connected layer #1
model.add(Flatten())
model.add(Dense(64))
model.add(Activation("relu"))

### Fully connecte dlayer #2
model.add(Dense(64))
model.add(Activation("relu"))

###Last fully connect layer, output must be equal to a number of classes 10 (0-9)
model.add(Dense(36)) 
model.add(Activation("softmax")) 


##run the model
model.compile(loss = "spare_categorial_crossentropy", optimizer = "adam", metrics = ['accuracy'])
model.fit(x_train_resize, epochs = 5, validation_split = 0.3)

model.save("ASLrecogintion.h5")