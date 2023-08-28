import abstractClass.model.*;

class AbstractClass {
    public static function main() {
        var animals:Array<Animal> = [new Cat(), new Dog()];

        for(animal in animals) {
            animal.Roar();
        }
    }
}