cmake_minimum_required(VERSION 3.0.0)
project(picker VERSION 0.1.0)


add_library(glad STATIC glad.c)
add_library(stb_image STATIC stb_image.cpp)

add_executable(picker picker.cpp)
target_link_libraries(picker glad)
target_link_libraries(picker glfw)
target_link_libraries(picker stb_image)
target_link_libraries(picker ${CMAKE_DL_LIBS})


