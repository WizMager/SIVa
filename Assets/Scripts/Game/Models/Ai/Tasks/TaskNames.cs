namespace Game.Models.Ai.Tasks
{
	public class TaskNames
	{
		public const string WAIT_RANDOM_TIME = "wait random time";
		public const string WAIT_RANDOM_TIME_PATH = "SelfState/wait random time";
		
		public const string WAIT_TIME = "Wait time";
		public const string WAIT_TIME_PATH = "SelfState/Wait time";
		
		public const string FIND_RANDOM_POINT = "find random point";
		public const string CONTINUE_GOING_TO_TARGET = "continue going to target";
		public const string WAIT_WHILE_WAKING = "wait while waking";
		public const string CAN_SEE_TARGET = "can see target";
		public const string STAY_IN_LAIR_ZONE = "stay in lair zone";
		public const string TARGET_IN_LAIR_ZONE = "target in lair zone";
		public const string HIDE = "hide";
		public const string APPEAR = "appear";
		public const string GO_TO_NOISE = "go to noise";

		public const string SET_MOVE_TARGET_TO_ATTACK_DISTANCE = "set move target to attack distance";
		public const string SET_NEXT_TARGET_WAY_POINT = "set next target way point";
		public const string SET_TARGET_RANDOM_HOSTILE_SPAWN_POINT = "set target as random hostile spawn point";
		
		public const string HAS_DESIRED_POSITION = "has desired position";
		public const string HAS_DESIRED_POSITION_PATH = "Enemy/has desired position";
		
		public const string IS_PLAYER_IN_RADIUS = "is player in radius";
		public const string REMOVE_DESIRED_POSITION = "remove desired position";
		
		public const string REMOVE_MOVE_TARGET_PATH = "Move/remove move target";
		public const string REMOVE_MOVE_TARGET = "remove move target";
		public const string MOVE_TO_TARGET_PATH = "Move/move to target";
		public const string PATROL_OWN_PATH_PATH = "Move/patrol own path";

		public const string MOVE_TO_TARGET = "move to target";
		public const string MOVE_TO_PIPE_END = "move to pipe end";
		
		public const string MOVE_TO_PIPE_END_PATH = "Move/move to pipe end";
		
		public const string MOVE_AWAY_FROM_FEAR_RADIUS = "move away from fear radius";
		public const string MOVE_AWAY_FROM_FEAR_RADIUS_PATH = "Move/move away from fear radius";
		
		public const string MOVE_TO_TARGET_BY_AXIS = "move to target by axis";
		public const string MOVE_TO_TARGET_BY_AXIS_PATH = "Move/move to target by axis";
		
		public const string MOVE_TO_TARGET_BY_CUSTOM_AXIS_PATH = "Move/move to target by custom axis";
		public const string MOVE_TO_TARGET_BY_CUSTOM_AXIS = "move to target by custom axis";
		
		public const string MOVE_TO_PLAYER = "move to player";
		public const string MOVE_TO_PLAYER_PATH = "Move/move to player";
		
		public const string MOVE_BY_DIRECTION = "move by direction";
		public const string MOVE_BY_DIRECTION_PATH = "Move/move by direction";

		public const string START_EXHAUSTION = "Start exhaustion";
		public const string START_EXHAUSTION_PATH = "SelfState/Start exhaustion";
		
		public const string SET_PLAYER_BLOCKING = "Set player blocking";
		public const string SET_PLAYER_BLOCKING_PATH = "SelfState/Set player blocking";
		
		public const string IS_TARGET_AVAILABLE = "is target available";
		public const string IS_TARGET_IN_ATTACK_DISTANCE = "is target in attack distance";
		
		public const string IS_TARGET_IN_ATTACK_ANGLE = "is target in attack angle";
		public const string LOOK_TO_TARGET = "look to target";
		public const string ATTACK = "attack";
		public const string WAIT_TARGET_AVAILABLE = "wait target available";
		public const string DEAD = "dead";
		public const string IDLE = "idle";
		public const string WANDER_AROUND_HOME = "wander around home";
		public const string MOVE_STOPPED = "move stopped";
		public const string STOP_MOVE = "stop move";
		
		public const string IS_TARGET_DEAD = "Is target dead";
		public const string IS_TARGET_DEAD_PATH = "Target/Is target dead";
		
		public const string IS_TARGET_LOCKED = "Is target locked";
		public const string IS_TARGET_LOCKED_PATH = "Target/Is target locked";
		
		public const string IS_TARGET_IN_LOOK_RANGE = "is target in look range";
		
		public const string HAS_TARGET = "Has target";
		public const string HAS_TARGET_PATH = "Target/Has target";
		
		public const string MOVE_TO_END_POINT = "move to end point";
		
		public const string LOOK_AT_TARGET = "look at target";
		public const string LOOK_AT_TARGET_PATH = "Move/look at target";
		
		public const string FREE_LOOK = "free look";
		public const string FREE_LOOK_PATH = "Move/free look";
		
		public const string MOVE_TO_INIT_POS = "move to init position";
		public const string MOVE_TO_INIT_POS_PATH = "Move/move to init position";
		
		public const string PATROL_OWN_PATH = "patrol own path";
		
		public const string REMOVE_TARGET = "Remove target";
		public const string REMOVE_TARGET_PATH = "Target/Remove target";
		
		public const string LOCK_TARGET = "Lock target";
		public const string LOCK_TARGET_PATH = "Target/Lock target";
		
		public const string PUSH_PLAYER = "Push player";
		public const string PUSH_PLAYER_PATH = "Target/Push player";
		
		public const string SET_TARGET_PLAYER = "set target player";
		
		public const string IS_ATTACKING = "is attacking";
		public const string IS_ATTACKING_PATH = "SelfState/is attacking";
		
		
		public const string SET_NEAREST_ENEMY_AS_TARGET = "set nearest enemy as target";
		
		public const string FOCUS_ON_TARGET = "focus on target";
		public const string FOCUS_ON_TARGET_PATH = "Enemy/focus on target";
		
		public const string ATTACK_ENEMY = "attack enemy";
		public const string ATTACK_ENEMY_PATH = "Enemy/attack enemy";
		
		public const string IS_REMAINING_DISTANCE_LOW = "is remaining distance low";
		
		public const string DISTANCE_PATH = "Target/Distance";
		public const string DISTANCE = "Distance";
		
		public const string COMPARE_DIR = "Compare dir";
		public const string COMPARE_DIR_PATH = "Target/Compare dir";
		
		public const string CROSSING_TIME = "Crossing time";
		public const string CROSSING_TIME_PATH = "Target/Crossing time";
		
		public const string WAIT_DISTANCE = "wait distance";
		
		public const string REMAINING_DISTANCE = "Remaining distance";
		public const string REMAINING_DISTANCE_PATH = "Target/Remaining distance";
		
		public const string TARGET_VELOCITY_CROSS_CIRCLE = "Target velocity cross circle";
		public const string TARGET_VELOCITY_CROSS_CIRCLE_PATH = "Target/Target velocity cross circle";
		
		public const string VELOCITY = "velocity";
		
		public const string CLOSER_THAN = "Closer than";
		public const string CLOSER_THAN_PATH = "Target/Closer than";
		
		public const string HORIZONTAL_LOCKED_DISTANCE_TO_TARGET = "horizontal locked distance to target";
		public const string HORIZONTAL_LOCKED_DISTANCE_TO_TARGET_PATH = "Target/horizontal locked distance to target";
		
		public const string MAKE_SLIDE_ACTION = "make slide action";
		public const string MAKE_SLIDE_ACTION_PATH = "Move/make slide action";
		
		public const string MAKE_SLIDE_WITH_PREDICTION_ACTION = "make slide with prediction action";
		public const string MAKE_SLIDE_WITH_PREDICTION_ACTION_PATH = "Move/make slide with prediction action";
		
		public const string CATCH_BALL = "catch ball";
		public const string CATCH_BALL_PATH = "Move/catch ball";
		
		public const string MISS = "miss";
		public const string MISS_PATH = "Move/miss";
		
		public const string MAKE_SLIDE_BACK_ACTION = "make slide back action";
		public const string MAKE_SLIDE_BACK_ACTION_PATH = "Move/make slide back action";
		
		public const string IS_SLIDING = "is sliding";
		public const string IS_SLIDING_PATH = "SelfState/is sliding";
		
		public const string IS_PURE_SLIDING = "is pure sliding";
		public const string IS_PURE_SLIDING_PATH = "SelfState/is pure sliding";
		
		public const string IS_STUN_EXIT = "is stun exit";
		public const string IS_STUN_EXIT_PATH = "SelfState/is stun exit";
		
		public const string IS_EXHAUSTION = "is exhaustion";
		public const string IS_EXHAUSTION_PATH = "SelfState/is exhaustion";
		
		public const string IS_STUN = "is stun";
		public const string IS_STUN_PATH = "SelfState/Is stun";
		
		public const string IS_REVERSE = "Is reverse";
		public const string IS_REVERSE_PATH = "SelfState/Is reverse";
		
		public const string SET_REVERSE = "Set reverse";
		public const string SET_REVERSE_PATH = "SelfState/Set reverse";
		
		public const string IS_IN_ACTION = "is in action";
		public const string IS_IN_ACTION_PATH = "SelfState/is in action";
		
		public const string IS_PLAYER_BLOCKING = "is player blocking";
		public const string IS_PLAYER_BLOCKING_PATH = "SelfState/is player blocking";
		
		public const string HAS_BALL_BOOST = "Has ball boost";
		public const string HAS_BALL_BOOST_PATH = "Target/Has ball boost";
		
		public const string HAS_IN_PIPE = "Has in pipe";
		public const string HAS_IN_PIPE_PATH = "Target/Has in pipe";

		public const string LOOK_AT_BALL_HIT_POINT = "look at ball hit point";
		public const string LOOK_AT_BALL_HIT_POINT_PATH = "Move/look at ball hit point";
		
		public const string SET_AIMING = "set aiming";
		public const string SET_AIMING_PATH = "Enemy/set aiming";
		
		public const string IS_AIMING = "is aiming";
		public const string IS_AIMING_PATH = "SelfState/is aiming";
		
		public const string IS_NOT_AIMING = "is not aiming";
		public const string IS_NOT_AIMING_PATH = "SelfState/is not aiming";
		
		public const string THROW_TOURNAMENT_BALL = "throw tournament ball";
		public const string THROW_TOURNAMENT_BALL_PATH = "Enemy/throw tournament ball";
		
		public const string SET_POWER = "set power"; 
		public const string SET_POWER_PATH = "Enemy/set power";
		
		public const string CREATE_DANGER_POINT_NEAR_BALL = "create danger point near ball"; 
		public const string CREATE_DANGER_POINT_NEAR_BALL_PATH = "Enemy/create danger point near ball";
		
		public const string TELEPORT_TO_DANGER_POINT = "teleport to danger point"; 
		public const string TELEPORT_TO_DANGER_POINT_PATH = "Move/teleport to danger point";
		
		public const string SET_CAN_THROW_BALL = "set can throw ball";
		public const string SET_CAN_THROW_BALL_PATH = "Enemy/set can throw ball";
		
		public const string DESTROY_OWN_DANGER_MARKERS = "destroy own danger markers";
		public const string DESTROY_OWN_DANGER_MARKERS_PATH = "Enemy/destroy own danger markers";
		
		public const string IS_CAN_THROW_BALL = "is can throw ball";
		public const string IS_CAN_THROW_BALL_PATH = "SelfState/is can throw ball";
		
		public const string IS_NOT_CAN_THROW_BALL = "is not can throw ball";
		public const string IS_NOT_CAN_THROW_BALL_PATH = "SelfState/is not can throw ball";
		
		public const string IS_BALL_IN_PATH_TARGET = "Is ball in path target";
		public const string IS_BALL_IN_PATH_TARGE_PATH = "Ball/Is ball in path target";
		
		public const string IS_WILL_HIT_GATE = "Is will hit gate";
		public const string IS_WILL_HIT_GATE_PATH = "SelfState/Is will hit gate";
		
		public const string IS_NOT_WILL_HIT_GATE = "is not will hit gate";
		public const string IS_NOT_WILL_HIT_GATE_PATH = "SelfState/is not will hit gate";
		
		public const string IS_IN_START_POSITION_PATH = "SelfState/is in start position";
		public const string IS_IN_START_POSITION = "is in start position";
		
		// tournament
		public const string TOURNAMENT_START_AIMING_AGAIN_RESET_DELAY = "tournament start aiming again reset delay";
		public const string TOURNAMENT_START_AIMING_AGAIN_RESET_DELAY_PATH = "Tournament/tournament start aiming again reset delay";
		
		public const string TOURNAMENT_WAIT_BEFORE_THROW_BALL_TIME = "tournament wait before throw ball time";
		public const string TOURNAMENT_WAIT_BEFORE_THROW_BALL_TIME_PATH = "Tournament/tournament wait before throw ball time";
		
		public const string TOURNAMENT_ALLOW_THROW_BALL_DELAY = "tournament allow throw ball delay";
		public const string TOURNAMENT_ALLOW_THROW_BALL_DELAY_PATH = "Tournament/tournament allow throw ball delay";
		
		public const string IS_NOT_STUN = "is not stun";
		public const string IS_NOT_STUN_PATH = "SelfState/is not stun";
		
		public const string REPEATER_ALL_UNTIL_FAILURE = "repeatAllUntilFailure";
		public const string REPEATER_ALL_UNTIL_FAILURE_PATH = "Decorators/repeatAllUntilFailure";
	}
}