using DCL; /*note how you should not delete the file of micrsosoft because if 
you delete it then DCL.dll will not work .NET*/

namespace test {
	class program {
		static void Main(string[]args) {
			Xcase.from = "object_"; /*where to read the file here is the file 
			name: object_*/
			Xcase.index();/*this is the most important place without this 
			Xcase.from won't work.*/ 
		}
	}
}